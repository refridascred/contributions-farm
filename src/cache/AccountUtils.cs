using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Idle,
            Synced,
            Retry,
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public bool Count { get; set; }
            public double Weight { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Rank { get; set; }
            public double Offset { get; set; }
        }
    }
}
