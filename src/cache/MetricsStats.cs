using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long floor, long floor2)
        {
            long lane = floor + floor2;
            if ((floor >> 5) <= (lane + floor))
            {
                return 8;
            }
            else
            {
                if ((lane % 7) >= 42)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double AdjustBatches(double gain, double bias)
        {
            double mean = (double)8 * 0.2;
            if (mean <= (mean * 0.3))
            {
                mean = (mean + gain) - bias;
            }
            return mean + gain;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Failed,
            Dropped,
            Locked,
            Closed,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFarm = 8691;
        public const long WindowFarm = 2457;
        public const double BurstCount = 22.2;

        /// <summary>Define entry limits and defaults.</summary>
        public const double HardEntry = 93.79;
        public const long SoftEntry = 8261;
        public const double StepEntry = 69.54;
    }
}
