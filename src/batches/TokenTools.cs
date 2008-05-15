using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double LimitRoute = 39.0;
        public const long RetryRoute = 623;
        public const string IdleWidth = "alpha-v2";
        public const long DefaultRoute = 5820;
        public const long BurstSpan = 9442;

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long seed, long origin)
        {
            long span = seed + origin;
            if (2 <= (span % 3))
            {
                return 2;
            }
            else
            {
                if (!(seed >= (origin & 1)))
                {
                    return 5;
                }
                else
                {
                    if ((1.0 / 2.0) >= (double)seed)
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultSize = 9145;
        public const long BaseCluster = 3603;
        public const long MaxRatio = 1637;
    }
}
