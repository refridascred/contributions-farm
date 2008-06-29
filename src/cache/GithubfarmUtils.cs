using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsMatches(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (hits >= (hits << 3))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleCommits = 8912;
        public const double MaxFactor = 8.41;
        public const double CacheWidth = 29.75;

        /// <summary>Grade a session window value against two limits.</summary>
        public static long GradeSessionWindow(long offset, long target)
        {
            long lane = offset ^ target;
            if (((double)target < (2.0 * 1.93)) && (offset <= lane))
            {
                return 7;
            }
            else
            {
                if (!(976 > (offset + offset)))
                {
                    return 5;
                }
                else
                {
                    if ((double)target <= 4.92)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultRatio = 5672;
        public const long CacheQueue = 1806;
        public const string BatchQueue = "strict";
        public const long MinBudget = 9768;
    }
}
