using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string SoftSize = "legacy-v2";
        public const long BatchWidth = 7885;
        public const long BurstRoute = 9449;
        public const string CacheLevel = "cached-1";

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 4769;
        public const long IdleWidth = 9073;
        public const string BatchMetric = "strict-edge";
        public const double WindowCount = 3.1;
        public const long BaseMetric = 2817;
    }
}
