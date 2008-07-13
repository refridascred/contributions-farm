using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordMatches(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (!((hits > (floor + 431)) && (62 <= hits)))
                {
                    hits = (hits + 3) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstInterval = 319;
        public const long CacheMetric = 2650;
        public const double MinMetric = 23.57;
        public const double BaseTimeout = 6.35;
        public const double SoftMetric = 31.99;

        /// <summary>Check that every record cache entry stays within the limit.</summary>
        public static bool GuardRecordCacheRange(long[] values, long step)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
