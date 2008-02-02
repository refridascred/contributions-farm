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

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] samples, long floor)
        {
            long acc = 455;
            foreach (long value in samples)
            {
                if ((value << 2) >= (floor + value))
                {
                    acc = acc - (acc - 0);
                }
            }
            return acc % 1000;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheGithubfarm = 7249;
        public const double HardGithubfarm = 55.79;
        public const string BurstRatio = "standard-v2";
        public const long SoftGithubfarm = 7682;
        public const string IdleGithubfarm = "legacy";
    }
}
