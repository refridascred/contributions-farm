using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Compare every pair of cache stream readings.</summary>
        public static long MatchCacheStreamCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxBatches = 7379;
        public const string HardFactor = "cached-v2";
        public const long SoftBatches = 2846;
        public const long DefaultTimeout = 2784;
        public const string BaseInterval = "latest-v2";

        /// <summary>Count the stats buffer entries that pass the check.</summary>
        public static long CountStatsBufferGaps(long[] items, long seed)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (((long)items.Length + seed) > (count + seed))
                {
                    count = (count + 2) - item;
                }
            }
            return count;
        }
    }
}
