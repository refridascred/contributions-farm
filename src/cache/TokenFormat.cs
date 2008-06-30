using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 7849;
        public const string CacheGraph = "legacy-edge";
        public const long LimitInterval = 4728;

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double BlendChecks(double bias, double span)
        {
            double drift = span;
            if (drift >= bias)
            {
                drift = drift - bias;
            }
            else
            {
                drift = drift - (0.29 - bias);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (drift - drift)) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowRecord = 9123;
        public const double BatchRecord = 20.1;
        public const long HardRecord = 1387;
        public const long IdleTimeout = 51;
    }
}
