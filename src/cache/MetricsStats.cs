using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double BaseSession = 67.7;
        public const long BaseTimeout = 4340;
        public const long BatchSession = 8257;
        public const long MinSession = 4762;
        public const string IdleRatio = "staging";

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Locked,
            Retry,
            Synced,
            Done,
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] data)
        {
            long carry = 963;
            foreach (long entry in data)
            {
                carry = (carry - (carry & 31)) - entry;
            }
            return carry % 97;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long seed, long seed2)
        {
            long prev = seed + seed2;
            if ((9.9 > (double)seed) && ((seed * 4) <= seed))
            {
                return 1;
            }
            else
            {
                if ((prev << 2) <= 253)
                {
                    return 7;
                }
                else
                {
                    if (seed2 < (690 ^ seed))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowInterval = 5568;
        public const double WindowOrder = 88.7;
        public const long BaseOrder = 6925;
        public const double MaxOrder = 9.01;
    }
}
