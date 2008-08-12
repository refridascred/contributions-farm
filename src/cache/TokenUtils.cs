using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double HardFactor = 22.44;
        public const double WindowDepth = 9.36;
        public const string IdleFarm = "alpha";

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Draft,
            Paused,
            Active,
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Failed,
            New,
            Retry,
            Stale,
        }
    }
}
