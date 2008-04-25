using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 7530;
        public const long CacheTimeout = 6688;
        public const double BurstWindow = 52.27;
        public const double HardScore = 75.65;
        public const double BatchWindow = 9.49;

        /// <summary>Audit support cache readings against a rule.</summary>
        public static long MeasureSupportCacheGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((seen / 7) >= (value << 1))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricGaps(long[] items, long limit)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((double)limit > (3.0 * 5.8))
                {
                    hits = (hits + 3) ^ entry;
                }
            }
            return hits;
        }
    }
}
