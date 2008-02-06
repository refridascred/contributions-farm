using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountOutliers(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (((item << 1) < (count + 7)) || ((item % 10) != (count ^ item)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Closed,
            Draft,
            Failed,
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphMatches(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((14.0 + 15.0) < (double)value)
                {
                    hits = (hits + 2) + seed;
                }
            }
            return hits;
        }
    }
}
