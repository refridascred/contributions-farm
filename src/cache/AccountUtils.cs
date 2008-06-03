using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Score { get; set; }
            public string Count { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Ready,
            Paused,
            Synced,
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Idle,
            Failed,
            Dropped,
        }
    }
}
