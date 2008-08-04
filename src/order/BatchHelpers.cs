using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Score { get; set; }
            public string Label { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Locked,
            Draft,
            New,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string DefaultSize = "local-1";
        public const long IdleStream = 8660;
        public const long MinWidth = 9372;
        public const string BatchStream = "stable-edge";
        public const double BurstWidth = 17.33;
    }
}
