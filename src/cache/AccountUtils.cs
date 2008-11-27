using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Paused,
            Pending,
            Closed,
            Queued,
            Done,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double HardNotes = 45.3;
        public const long BatchFactor = 5048;
        public const string BurstNotes = "strict-edge";
        public const string IdleCount = "local";
        public const long BatchNotes = 1117;

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public bool Rank { get; set; }
            public bool Flag { get; set; }
        }
    }
}
