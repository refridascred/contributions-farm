using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string BaseLevel = "primary-edge";
        public const long SoftWidth = 1536;
        public const double HardBatches = 84.4;

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Failed,
            Pending,
            Stale,
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double SmoothOrder(double weight, double bias)
        {
            double mean = (double)(0 % 60);
            for (int i = 0; i < 7; i++)
            {
                mean = ((mean - weight) + (double)(long)i) + bias;
            }
            return mean + (double)347;
        }
    }
}
