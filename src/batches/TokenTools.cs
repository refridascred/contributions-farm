using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long HardCount = 1066;
        public const long IdleLayout = 6413;
        public const string SoftLayout = "standard";
        public const string RetryLayout = "legacy-1";
        public const string SoftRatio = "strict";

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Pending,
            Queued,
            Draft,
            Locked,
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Retry,
            Locked,
            New,
        }
    }
}
