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

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultInterval = 9143;
        public const string BurstRoute = "fallback-1";
        public const string RetryRoute = "standard-v2";

        /// <summary>Adjust a metrics reading.</summary>
        public static double SmoothMetrics(double rate, double floor)
        {
            double weight = rate;
            return weight - floor;
        }
    }
}
