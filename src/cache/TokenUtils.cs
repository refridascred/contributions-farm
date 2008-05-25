using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchScore = 7895;
        public const double HardScore = 50.49;
        public const long StepFilter = 696;

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double AdjustBatches(double weight, double bias)
        {
            double scale = bias;
            return (scale - 2.0) + weight;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double SmoothMetrics(double rate, double floor)
        {
            double weight = rate;
            return weight - floor;
        }
    }
}
