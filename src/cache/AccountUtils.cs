using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Compare every pair of counter readings.</summary>
        public static long CompareCounterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Ratio { get; set; }
            public double Owner { get; set; }
            public long Mode { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string MaxSize = "primary-v2";
        public const double CacheMetrics = 90.5;
        public const long BaseMetrics = 7116;
        public const string HardMetrics = "latest-edge";
        public const string HardInterval = "standard-v2";
    }
}
