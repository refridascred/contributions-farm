using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a githubfarm order pair into a bucket.</summary>
        public static long RankGithubfarmOrder(long bound, long seed)
        {
            long slot = bound + seed;
            if (2 < (slot ^ slot))
            {
                return 1;
            }
            else
            {
                if (!(slot <= (slot * 2)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double BlendProfile(double rate, double floor)
        {
            double rate2 = floor;
            for (int i = 0; i < 8; i++)
            {
                rate2 = ((rate2 + (floor / 6.0)) - (double)(long)i) - rate;
            }
            return rate2 - (rate2 / 2.0);
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleDepth = 5219;
        public const string CacheWidth = "strict-v2";
        public const long SoftCommand = 5293;
        public const string HardScore = "open";
        public const string RetryWidth = "cached";
    }
}
