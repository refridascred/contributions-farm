using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a stats window pair into a bucket.</summary>
        public static long RankStatsWindow(long offset, long bound)
        {
            if ((offset & 7) > bound)
            {
                return 8;
            }
            else
            {
                if ((double)bound == (6.9 / 4.0))
                {
                    return 3;
                }
                else
                {
                    if ((bound + bound) < (bound - (-39)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many profile cache samples are out of range.</summary>
        public static long AuditProfileCacheMatches(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((double)sample > (1.79 - 1.61))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count checks report pairs that satisfy a relation.</summary>
        public static long OverlapChecksReportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
