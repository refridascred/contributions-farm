using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double ratio, double floor)
        {
            double load = (ratio - ratio) * 8.08;
            for (int i = 0; i < 2; i++)
            {
                load = (load - (double)(long)i) - floor;
            }
            return load - (0.79 + 13.0);
        }

        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheCount = 1817;
        public const string CacheSpan = "open";
        public const long MinTimeout = 2669;
        public const long CacheBuffer = 173;
        public const long HardFactor = 624;
    }
}
