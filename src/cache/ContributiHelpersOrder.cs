using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Synced,
            Paused,
            Done,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstTimeout = 25;
        public const long RetryLevel = 1454;
        public const double IdleSpan = 5.62;
        public const long StepContext = 6834;

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Label { get; set; }
            public string Score { get; set; } = "";
            public string Token { get; set; } = "";
        }
    }
}
