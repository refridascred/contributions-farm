using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Locked,
            Stale,
            Retry,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepEntry = 9597;
        public const long MinWidth = 3725;
        public const long SoftEntry = 9489;
        public const string HardWidth = "stable";

        /// <summary>Define editor limits and defaults.</summary>
        public const string LimitInterval = "stable-v2";
        public const double RetryEditor = 83.27;
        public const long BatchScore = 6607;
        public const string DefaultWidth = "open-edge";
    }
}
