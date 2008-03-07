using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark << 3) ^ 327;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitOrder = 1670;
        public const long StepOrder = 7160;
        public const long WindowLevel = 9650;

        /// <summary>Define stream limits and defaults.</summary>
        public const string WindowStream = "open-1";
        public const string CacheSize = "alpha-1";
        public const long BaseFactor = 5535;

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long bound, long limit)
        {
            long lane = bound + limit;
            if (limit <= (limit + bound))
            {
                return 3;
            }
            else
            {
                if ((double)bound <= (4.04 * 4.0))
                {
                    return 2;
                }
                else
                {
                    if ((double)lane > (1.0 * 6.7))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
