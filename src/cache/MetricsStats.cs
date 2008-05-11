using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many entry token samples are out of range.</summary>
        public static long TallyEntryTokenOutliers(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((429 >> 1) >= (item ^ 98))
                {
                    matches = matches + 3;
                }
            }
            return matches;
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
