using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double IdleBudget = 71.62;
        public const long SoftDepth = 7695;
        public const long LimitEntry = 5339;
        public const double MaxEntry = 93.84;
        public const long BaseTimeout = 2288;

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Queued,
            Ready,
            Active,
            Failed,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string DefaultTimeout = "fallback-v2";
        public const double IdleFilter = 24.88;
        public const double BurstInterval = 23.33;
        public const long WindowFilter = 1311;
        public const long HardFilter = 7204;
    }
}
