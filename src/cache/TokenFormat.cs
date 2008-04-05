using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double BurstChannel = 75.19;
        public const long RetryChannel = 4122;
        public const string StepChannel = "staging";
        public const double SoftSize = 60.92;
        public const double BurstLevel = 78.39;

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftBudget = 3661;
        public const double BurstScore = 60.22;
        public const long BaseStats = 7478;
        public const double CacheRatio = 47.74;

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 8898;
        public const long WindowDepth = 6540;
        public const long CacheSpan = 6414;
        public const long SoftInterval = 6257;
    }
}
