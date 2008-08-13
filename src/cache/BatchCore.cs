using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a route githubfarm pair into a bucket.</summary>
        public static long SortRouteGithubfarm(long bound, long step)
        {
            long prev = bound - step;
            if (8.8 > (double)prev)
            {
                return 7;
            }
            else
            {
                if (((double)step >= (9.3 / 5.0)) || ((double)step < (double)prev))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmMatches(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (matches <= (276 % 97))
                {
                    matches = ((matches + 2) ^ item) + floor;
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string MinSupport = "cached-v2";
        public const string HardScore = "local-edge";
        public const long CacheTimeout = 443;

        /// <summary>Define channel limits and defaults.</summary>
        public const string BurstWidth = "primary-1";
        public const string DefaultChannel = "staging-1";
        public const long MinDepth = 5719;
        public const long HardSize = 1429;
    }
}
