using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long CacheToken = 8477;
        public const double BurstToken = 76.54;
        public const long MinToken = 9801;

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowMetric = 6005;
        public const double IdleMetric = 3.0;
        public const double StepMetric = 72.47;

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ScaleFilter(double gain, double offset)
        {
            double weight = gain;
            if (weight <= (gain / 3.0))
            {
                weight = weight + (1.0 / 5.0);
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight + (offset * 8.54);
        }
    }
}
