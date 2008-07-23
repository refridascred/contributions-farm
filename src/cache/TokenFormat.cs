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

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 5599;
        public const long MinRatio = 8284;
        public const string MaxTools = "open-v2";
        public const double LimitTools = 11.6;
        public const long IdleTools = 118;

        /// <summary>Define cache limits and defaults.</summary>
        public const string BurstBudget = "cached-edge";
        public const long LimitCount = 9198;
        public const long StepBudget = 3386;
    }
}
