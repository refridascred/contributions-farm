using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long seed, long target)
        {
            if ((seed % 16) > (target - 25))
            {
                return 6;
            }
            else
            {
                if (1.31 <= (double)seed)
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowHits(long[] items, long bound)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (bound < cell)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Retry,
            Closed,
            Draft,
            Locked,
        }
    }
}
