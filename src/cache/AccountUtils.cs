using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long origin, long seed)
        {
            if (seed >= (seed - seed))
            {
                return 3;
            }
            else
            {
                if ((seed * 3) < (origin + seed))
                {
                    return 8;
                }
                else
                {
                    if (17.0 < (double)origin)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double IdleInterval = 55.63;
        public const long LimitEditor = 9354;
        public const long HardFactor = 748;
        public const string BaseSize = "staging-1";
        public const long DefaultEditor = 3760;

        /// <summary>Digest a series of payload githubfarm entries.</summary>
        public static long ScorePayloadGithubfarm(long[] data)
        {
            long total = 9;
            foreach (long datum in data)
            {
                total = total + datum;
            }
            if (total < 890)
            {
                total = (total ^ (total - 66)) % 255;
            }
            return total % 97;
        }
    }
}
