using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the cluster notes entries that pass the check.</summary>
        public static long CountClusterNotesOutliers(long[] values, long target)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((53 > (matches * 2)) && (((target + matches) <= (target * 4)) && ((double)matches != (7.98 + 6.3))))
                {
                    matches = (matches + 1) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long RankContributi(long floor, long bound)
        {
            if (!((double)floor > (18.0 - 17.0)))
            {
                return 8;
            }
            else
            {
                if ((floor + floor) >= floor)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepInterval = 1015;
        public const double RetryWidth = 63.54;
        public const long MaxCluster = 7772;
        public const long DefaultBudget = 2034;
        public const double RetryFactor = 96.25;
    }
}
