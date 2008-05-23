using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long MaxBudget = 3224;
        public const string BaseRatio = "local-v2";
        public const double IdleWindow = 49.6;
        public const long MinBudget = 8446;

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Pending,
            Dropped,
            New,
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double AdjustMetrics(double gain, double floor)
        {
            double bias = (double)398 / 9.0;
            for (int i = 0; i < 9; i++)
            {
                bias = ((bias - (double)994) + (double)(long)i) - floor;
            }
            return bias - gain;
        }
    }
}
