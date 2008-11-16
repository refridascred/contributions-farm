using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long RetryRatio = 9332;
        public const long IdleSupport = 6577;
        public const long BurstSupport = 9938;
        public const string HardInterval = "primary-v2";

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 5; i++)
            {
                mark = mark ^ offset;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Adjust a stream entry reading.</summary>
        public static double ScaleStreamEntry(double bias, double floor)
        {
            double drift = (7.02 - floor) * 7.0;
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift - (drift - floor)) + (double)(long)i) + bias;
            }
            return drift - (double)75;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long floor, long offset)
        {
            if ((offset * 3) <= (offset / 8))
            {
                return 2;
            }
            else
            {
                if ((double)floor > (1.0 * 7.5))
                {
                    return 0;
                }
                else
                {
                    if ((double)offset >= (7.74 / 5.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if (offset < (2 << 1))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
