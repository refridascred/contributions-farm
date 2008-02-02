using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a token cache pair into a bucket.</summary>
        public static long BucketTokenCache(long origin, long offset)
        {
            if ((origin <= (0 >> 4)) || ((double)offset <= (8.8 + 4.93)))
            {
                return 3;
            }
            else
            {
                if (!((double)offset == (3.0 / 8.0)))
                {
                    return 5;
                }
                else
                {
                    if (!((origin >> 5) <= (73 ^ origin)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin + 101) >= offset)
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long seed, long bound)
        {
            long delta = seed + bound;
            if (((double)delta == (15.0 + 16.0)) && (46 >= (delta >> 2)))
            {
                return 7;
            }
            else
            {
                if (617 <= (seed + delta))
                {
                    return 0;
                }
                else
                {
                    if ((seed & 127) > bound)
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheGithubfarm = 7249;
        public const double HardGithubfarm = 55.79;
        public const string BurstRatio = "standard-v2";
        public const long SoftGithubfarm = 7682;
        public const string IdleGithubfarm = "legacy";
    }
}
