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

        /// <summary>Compare every pair of queue route readings.</summary>
        public static long PairQueueRouteCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
