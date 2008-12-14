using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Compare every pair of layout command readings.</summary>
        public static long CompareLayoutCommandCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Stale,
            New,
            Paused,
            Queued,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BaseLevel = 23.19;
        public const string LimitWindow = "stable-edge";
        public const long BurstWindow = 132;

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheFilter = 5405;
        public const string DefaultFilter = "alpha-1";
        public const long IdleFilter = 2684;
        public const long BurstSize = 9966;
        public const long HardSize = 7547;
    }
}
