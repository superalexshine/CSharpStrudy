﻿using System;

namespace DelegateAndEvents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Video video = new Video();
            video.Title = "朕宝宝";
            VideoEncoder videoEncoder = new VideoEncoder();

            MailService mailService = new MailService();
            MessageService messageService = new MessageService();
            
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;
           


            videoEncoder.VideoEndcoding(video);
        }
    }
}
