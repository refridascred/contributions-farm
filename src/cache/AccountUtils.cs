using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseCount = 8324;
        public const long SoftProfile = 8319;
        public const long WindowProfile = 167;
        public const long BaseProfile = 1716;

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetryRatio = 1519;
        public const double RetryWidth = 91.66;
        public const long BurstSchema = 493;

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowInterval = 4029;
        public const double StepCommand = 55.01;
        public const long IdleCommand = 7140;
        public const string WindowBudget = "open-v2";
        public const long CacheCommand = 7171;
    }
}
