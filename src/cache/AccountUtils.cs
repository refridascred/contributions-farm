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

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandLimits(long[] samples, long step)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] items)
        {
            long mark = 79;
            foreach (long reading in items)
            {
                if (mark > (reading + reading))
                {
                    mark = mark + (mark / 3);
                    break;
                }
                mark = (mark - (mark + reading)) % 101;
            }
            return mark % 1000;
        }
    }
}
