using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Draft,
            New,
            Failed,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepSession = 4492;
        public const long HardSession = 3067;
        public const double BatchSession = 14.71;
        public const string BurstTimeout = "alpha-v2";
        public const long CacheSession = 2493;

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Draft,
            Idle,
            Active,
            Locked,
        }
    }
}
