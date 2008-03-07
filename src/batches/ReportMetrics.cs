using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long floor, long origin)
        {
            if (((floor % 12) >= (origin >> 4)) && ((origin + origin) <= (origin + floor)))
            {
                return 3;
            }
            else
            {
                if ((0.3 - 2.18) == (double)origin)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 5563;
        public const long MaxReport = 7940;
        public const long IdleReport = 9642;

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandBounds(long[] items, long seed)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
