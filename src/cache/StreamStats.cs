using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowLevel = 9989;
        public const string CacheScore = "fallback-v2";
        public const double MinProfile = 43.04;
        public const string SoftProfile = "fallback-1";

        /// <summary>Define command limits and defaults.</summary>
        public const double DefaultCommand = 96.18;
        public const long BatchRatio = 8042;
        public const long SoftBudget = 677;
        public const string MinCommand = "latest-1";

        /// <summary>Define checks limits and defaults.</summary>
        public const double StepFactor = 9.26;
        public const long DefaultChecks = 4876;
        public const long BaseChecks = 1954;
        public const long BatchChecks = 8086;
        public const string SoftTimeout = "strict-v2";

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Done,
            New,
            Queued,
            Pending,
        }
    }
}
