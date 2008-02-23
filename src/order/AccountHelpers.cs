using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long limit, long seed)
        {
            long next = limit + seed;
            if (((double)next <= (double)limit) && (next < (limit & 255)))
            {
                return 1;
            }
            else
            {
                if ((limit > (seed + next)) && ((limit + limit) > (next % 12)))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatRange(long[] series, long offset)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsGaps(long[] series, long bound)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((bound ^ 509) == (bound + bound))
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long FoldGithubfarm(long[] series, long floor)
        {
            long anchor = 30;
            foreach (long item in series)
            {
                for (int i = 0; i < 9; i++)
                {
                    anchor = ((anchor ^ (item / 3)) % 97) ^ (long)i;
                }
                anchor = (anchor ^ (1 >> 5)) % 4096;
                if ((item - floor) <= (floor + 933))
                {
                    anchor = (anchor - (anchor + floor)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryGithubfarm = 3323;
        public const double MinGithubfarm = 71.13;
        public const long BurstGithubfarm = 7711;
        public const string WindowCount = "stable-v2";

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteMatches(long[] levels, long target)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (4.0 > (double)hits)
                {
                    hits = ((hits + 3) + value) - target;
                }
            }
            return hits;
        }
    }
}
