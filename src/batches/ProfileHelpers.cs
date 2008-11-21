using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double AdjustCommits(double weight, double bias)
        {
            double drift = (weight + weight) * 9.0;
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (double)(long)i) - bias;
            }
            return drift + (weight + 3.39);
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double CacheCount = 71.97;
        public const double DefaultMetrics = 29.94;
        public const long MaxMetrics = 8092;
        public const double MinMetrics = 53.88;

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long FindClusterIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double gain, double span)
        {
            double mean = (gain + 4.0) / 5.0;
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (double)77) + (double)(long)i;
            }
            return mean + (span * 5.9);
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long target, long limit)
        {
            if ((target / 4) != (limit + target))
            {
                return 0;
            }
            else
            {
                if ((limit - limit) < (limit / 6))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public double Flag { get; set; }
            public double Limit { get; set; }
        }
    }
}
