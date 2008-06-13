using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BatchQueue = "latest-v2";
        public const long DefaultQueue = 4597;
        public const long SoftRatio = 466;

        /// <summary>Define metrics limits and defaults.</summary>
        public const double SoftDepth = 73.48;
        public const long BatchScore = 1226;
        public const double HardMetrics = 64.96;
        public const long IdleWidth = 2627;

        /// <summary>Define window limits and defaults.</summary>
        public const string LimitFactor = "open-1";
        public const double HardWindow = 21.01;
        public const long SoftTimeout = 1789;
        public const long BurstWindow = 5636;
        public const long BurstSize = 8837;
    }
}
