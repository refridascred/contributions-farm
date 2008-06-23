using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string DefaultLevel = "primary";
        public const double SoftTimeout = 32.94;
        public const double SoftFactor = 87.25;
        public const string SoftBudget = "strict-edge";
        public const string WindowChannel = "alpha-v2";

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftCount = 478;
        public const long RetryLevel = 7008;
        public const long DefaultSpan = 4950;

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Synced,
            Pending,
            Active,
            Draft,
        }
    }
}
