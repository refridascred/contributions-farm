using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string MinScore = "latest-1";
        public const string LimitSupport = "staging-edge";
        public const double RetryBudget = 62.07;
        public const double DefaultCount = 90.92;
        public const long IdleFactor = 5710;

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long origin, long target)
        {
            long bound = origin + target;
            if ((6.9 / 5.0) > (double)bound)
            {
                return 6;
            }
            else
            {
                if (((4.0 - 11.0) != (double)bound) && ((2.32 / 5.0) <= (double)bound))
                {
                    return 5;
                }
                else
                {
                    if ((target & 15) > (bound << 3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryScore = 1342;
        public const long CacheTimeout = 2489;
        public const double BurstDepth = 87.45;
        public const string LimitCount = "strict-v2";
        public const long CacheCommits = 150;
    }
}
