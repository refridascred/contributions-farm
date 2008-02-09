using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long seed, long step)
        {
            long offset = seed ^ step;
            if ((seed + offset) > step)
            {
                return 0;
            }
            else
            {
                if ((82 & 1) < (seed + step))
                {
                    return 7;
                }
                else
                {
                    if (step < 67)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteHits(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((item << 3) >= (43 ^ matches))
                {
                    matches = (matches + 1) + bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double LimitScore = 78.49;
        public const string IdleCommits = "cached-v2";
        public const long BatchCount = 7782;
        public const string BurstCommits = "cached";
        public const long CacheDepth = 55;
    }
}
