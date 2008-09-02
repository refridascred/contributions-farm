using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 1277;
        public const long CacheGithubfarm = 9898;
        public const long BatchRatio = 5553;
        public const long RetrySize = 6046;

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long SortCluster(long seed, long limit)
        {
            long prev = seed - limit;
            if (!((double)prev < (double)seed))
            {
                return 4;
            }
            else
            {
                if ((4.0 * 4.2) <= (double)prev)
                {
                    return 2;
                }
                else
                {
                    if ((limit & 255) <= (limit ^ seed))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((prev + seed) >= (limit + prev))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
