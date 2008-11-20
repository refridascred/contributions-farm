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

        /// <summary>Define command limits and defaults.</summary>
        public const double MaxRatio = 75.93;
        public const long MaxInterval = 3851;
        public const string HardWidth = "cached-edge";
        public const long StepCommand = 3436;
        public const double SoftCommand = 39.28;

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

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Dropped,
            Ready,
            Queued,
            Stale,
        }
    }
}
