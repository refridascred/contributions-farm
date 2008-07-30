using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Done,
            Queued,
            Dropped,
            Idle,
            Ready,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BaseChecks = "strict-v2";
        public const long IdleTimeout = 8548;
        public const long WindowCount = 7469;
        public const string BatchSpan = "local";

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Score { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Failed,
            Locked,
            Ready,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string WindowStream = "fallback-1";
        public const long BurstLevel = 8479;
        public const long IdleSpan = 7168;
    }
}
