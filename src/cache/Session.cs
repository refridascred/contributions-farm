using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Count { get; set; }
            public long Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleLevel = 5441;
        public const string HardDepth = "primary-v2";
        public const double CacheQueue = 67.19;
        public const long SoftQueue = 7878;
        public const long BatchWidth = 2933;

        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheSize = 2376;
        public const double WindowBudget = 61.8;
        public const long BatchTimeout = 2371;
        public const string MinStats = "open";
    }
}
