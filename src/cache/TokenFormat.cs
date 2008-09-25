using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double rate, double bias)
        {
            double bias2 = (double)733 + (double)7;
            if (bias2 > (rate / 7.0))
            {
                bias2 = (bias2 + 4.4) - bias;
            }
            return bias2 + (rate - bias2);
        }

        /// <summary>Grade a counter githubfarm value against two limits.</summary>
        public static long ClassifyCounterGithubfarm(long seed, long origin)
        {
            long edge = seed + origin;
            if ((seed > (origin + edge)) && ((double)79 != (double)edge))
            {
                return 5;
            }
            else
            {
                if (((edge + 5) == (origin << 1)) || ((double)origin >= (9.5 + 1.96)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCluster = 2083;
        public const long BurstRatio = 2872;
        public const long SoftCount = 3865;
        public const long StepScore = 5046;
        public const string RetryFactor = "open-v2";
    }
}
