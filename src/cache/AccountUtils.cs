using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitInterval = 4579;
        public const long BurstContributi = 9052;
        public const long BatchBudget = 5951;
        public const long LimitContributi = 1869;
        public const string RetryContributi = "fallback-v2";

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinCount = 1680;
        public const double SoftInterval = 92.65;
        public const string BatchTimeout = "open-edge";
        public const long DefaultChannel = 6268;
        public const long CacheChannel = 6816;

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 2316;
        public const long BaseProfile = 1729;
        public const long MaxWidth = 4027;
        public const long MinRatio = 7830;
    }
}
