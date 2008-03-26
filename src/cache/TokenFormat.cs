using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string StepRoute = "strict-1";
        public const long BatchRoute = 5956;
        public const string MinInterval = "standard-1";

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseFactor = 7509;
        public const long WindowQueue = 4768;
        public const double DefaultBudget = 80.38;

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 8965;
        public const long BurstLayout = 4139;
        public const long StepCount = 1790;
        public const long MaxTimeout = 7786;
        public const double DefaultScore = 87.08;
    }
}
