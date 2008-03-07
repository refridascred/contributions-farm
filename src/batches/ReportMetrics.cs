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

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double LimitGithubfarm = 38.1;
        public const double BatchGithubfarm = 85.21;
        public const string CacheWidth = "alpha-edge";
        public const long BurstGithubfarm = 8283;
        public const string HardGithubfarm = "stable-edge";

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryBounds(long[] values, long seed)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
