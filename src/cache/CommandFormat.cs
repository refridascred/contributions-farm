using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long target, long offset)
        {
            long next = target - offset;
            if ((next / 3) <= (next * 2))
            {
                return 4;
            }
            else
            {
                if ((4 - next) <= offset)
                {
                    return 0;
                }
                else
                {
                    if ((target - next) <= (offset % 64))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSupport = 5988;
        public const double IdleCount = 27.29;
        public const long StepDepth = 3358;

        /// <summary>Define cache limits and defaults.</summary>
        public const string IdleCache = "primary-v2";
        public const string CacheLevel = "local-v2";
        public const long StepCache = 8510;
        public const long BatchCache = 6826;
        public const long BatchSize = 2356;

        /// <summary>Count the stats profile entries that pass the check.</summary>
        public static long AuditStatsProfileOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (cell < (cell ^ 807))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
