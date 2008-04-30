using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BaseRoute = 8216;
        public const long BatchTimeout = 3607;
        public const long RetryRoute = 2315;

        /// <summary>Define checks limits and defaults.</summary>
        public const string SoftChecks = "local-edge";
        public const long BurstFactor = 2658;
        public const long BatchDepth = 3729;
        public const long DefaultDepth = 2030;

        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double rate, double bias)
        {
            double load = bias;
            if (load < (double)596)
            {
                load = (load + (4.0 + load)) + rate;
            }
            return load - bias;
        }
    }
}
