using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseDepth = 3712;
        public const long LimitBudget = 7484;
        public const long RetrySpan = 180;

        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long seed, long offset)
        {
            if (((55 - seed) < seed) && ((seed - seed) <= (offset & 127)))
            {
                return 0;
            }
            else
            {
                if ((5.13 + 4.7) < (double)offset)
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenOutliers(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((double)limit == (double)hits)
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }
    }
}
