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

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardCounter = 3971;
        public const long StepCounter = 8380;
        public const double MaxSpan = 64.58;

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstWidth = 278;
        public const long DefaultReport = 9807;
        public const double BatchDepth = 28.83;
    }
}
