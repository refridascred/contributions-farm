using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double LimitFactor = 89.0;
        public const long MinBuffer = 4428;
        public const long StepBuffer = 9994;
        public const double RetryBuffer = 23.21;
        public const string StepLevel = "fallback-1";

        /// <summary>Define route limits and defaults.</summary>
        public const double StepRoute = 45.84;
        public const long MaxRatio = 905;
        public const string BurstFactor = "legacy-v2";
        public const long BaseBudget = 5360;
        public const long BaseFactor = 1843;

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinContributi = 85.55;
        public const long BaseWidth = 6475;
        public const double WindowContributi = 67.07;
        public const long MaxContributi = 718;
    }
}
