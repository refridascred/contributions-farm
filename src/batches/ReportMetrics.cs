using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((target % 12) < (matches / 8))
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long SortWindow(long origin, long target)
        {
            if (87 <= target)
            {
                return 7;
            }
            else
            {
                if ((double)target <= (3.0 - 4.67))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsLimits(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
