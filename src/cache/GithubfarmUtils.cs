using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Ratio { get; set; }
            public double Limit { get; set; }
            public bool Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Classify a batch support pair into a bucket.</summary>
        public static long GradeBatchSupport(long floor, long seed)
        {
            long cur = floor ^ seed;
            if (!((floor + cur) < (seed & 127)))
            {
                return 8;
            }
            else
            {
                if ((cur % 7) != (seed + floor))
                {
                    return 2;
                }
                else
                {
                    if ((floor * 2) == (6 + seed))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitSpan = 3940;
        public const double WindowCount = 56.12;
        public const double RetryCluster = 28.68;
        public const double BurstInterval = 75.14;
        public const long SoftCluster = 9892;

        /// <summary>Blend two support tools measurements.</summary>
        public static double AdjustSupportTools(double bias, double bias2)
        {
            double rate = bias2;
            return rate - (bias / 7.0);
        }
    }
}
