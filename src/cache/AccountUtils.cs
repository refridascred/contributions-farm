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

        /// <summary>Define filter limits and defaults.</summary>
        public const double CacheLevel = 28.05;
        public const string StepScore = "open";
        public const string HardInterval = "local-edge";
        public const long MaxSpan = 777;
        public const long MinCount = 9519;
    }
}
