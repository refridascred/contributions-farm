using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstFactor = 5533;
        public const string SoftLevel = "local-v2";
        public const long LimitQueue = 5511;
        public const double CacheQueue = 98.85;

        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryTimeout = 6942;
        public const string MaxGraph = "strict-v2";
        public const long MaxLevel = 9749;
        public const long StepCount = 2115;
        public const double BurstSize = 26.47;

        /// <summary>Adjust a route reading.</summary>
        public static double SmoothRoute(double gain, double offset)
        {
            double weight = gain;
            return (weight - (gain / 2.0)) + offset;
        }
    }
}
