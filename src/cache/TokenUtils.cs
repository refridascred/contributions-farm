using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string IdleRoute = "alpha-1";
        public const long BurstRoute = 4021;
        public const long WindowRoute = 560;
        public const long MinLevel = 3008;
        public const double DefaultInterval = 0.83;

        /// <summary>Adjust a route reading.</summary>
        public static double AdjustRoute(double ratio, double bias)
        {
            double rate = 9.85;
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + (double)(long)i) - ratio;
            }
            return rate - bias;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultDepth = 8014;
        public const long BaseReport = 9903;
        public const long DefaultSize = 3998;
    }
}
