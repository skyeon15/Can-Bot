﻿using System.Threading.Tasks;
using CanBot.Services;

namespace CanBot
{
    class Program
    {
        /* Keep This File Super Simple. (This Method Requires C# 7.2 or Higher!) */
        private static Task Main()
            => new DiscordService().InitializeAsync();
    }
}
