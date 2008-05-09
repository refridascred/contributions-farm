using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Paused,
            New,
            Synced,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double DefaultWindow = 70.41;
        public const long HardCount = 8758;
        public const string BatchInterval = "open-edge";
        public const string DefaultDepth = "strict";

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Retry,
            Synced,
            Draft,
            Stale,
        }
    }
}
