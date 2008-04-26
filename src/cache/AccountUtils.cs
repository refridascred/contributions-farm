using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Stale,
            Pending,
            Closed,
        }

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
