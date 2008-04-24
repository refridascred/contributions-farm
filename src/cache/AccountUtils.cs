using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFarm = 2371;
        public const string DefaultCount = "latest";
        public const long BatchCount = 3633;
        public const long SoftFarm = 981;
        public const long BaseRatio = 2135;

        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double ratio, double span)
        {
            double mean = 19.0;
            if (mean < ratio)
            {
                mean = mean + (span - ratio);
            }
            return mean - mean;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseLevel = 2660;
        public const double HardAlready = 83.39;
        public const double LimitAlready = 65.42;
    }
}
