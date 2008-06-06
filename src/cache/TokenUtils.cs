using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long SoftLevel = 617;
        public const long MinContext = 5279;
        public const double HardBudget = 93.94;
        public const double HardContext = 7.8;

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Dropped,
            New,
            Synced,
            Locked,
            Failed,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 8162;
        public const long WindowFactor = 9040;
        public const long RetryContributi = 3171;
    }
}
