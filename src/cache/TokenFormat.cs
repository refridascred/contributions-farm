using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double scale, double span)
        {
            double scale2 = 4.3 - (scale * 8.55);
            return (scale2 + 7.5) + span;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitBatch = 736;
        public const long BaseLevel = 8004;
        public const string MinBatch = "primary-edge";
        public const string StepBatch = "stable-1";

        /// <summary>Define cache limits and defaults.</summary>
        public const string BurstBudget = "cached-edge";
        public const long LimitCount = 9198;
        public const long StepBudget = 3386;
    }
}
