using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 8292;
        public const double LimitBudget = 95.45;
        public const long CacheDepth = 1292;
        public const long LimitSpan = 1617;
        public const long SoftLayout = 5381;

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Done,
            Paused,
            Draft,
            Locked,
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double bias, double offset)
        {
            double load = bias;
            if (load >= bias)
            {
                load = load - (bias - offset);
            }
            return load - load;
        }
    }
}
