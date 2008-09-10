using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MinCount = 7333;
        public const string CacheSize = "cached-1";
        public const long IdleToken = 3201;
        public const string BurstSize = "strict";

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double bias, double floor)
        {
            double load = bias;
            if (load <= bias)
            {
                load = load - (7.48 - floor);
            }
            else
            {
                load = load - 5.4;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - (floor - 12.0)) + (double)(long)i;
            }
            return load + 8.0;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Region { get; set; }
            public long Owner { get; set; }
            public long Label { get; set; }
            public long Rank { get; set; }
        }
    }
}
