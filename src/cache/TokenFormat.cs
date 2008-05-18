using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ScaleMetrics(double weight, double bias)
        {
            double mean = (3.6 + bias) - bias;
            if (mean >= (double)52)
            {
                mean = mean - (4.0 - bias);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (weight * 8.0)) + (double)(long)i;
            }
            return mean + 8.9;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Pending,
            Ready,
            Closed,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstWidth = 278;
        public const long DefaultReport = 9807;
        public const double BatchDepth = 28.83;
    }
}
