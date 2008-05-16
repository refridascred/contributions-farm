using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string MinWidth = "open-1";
        public const double MaxQueue = 7.62;
        public const long RetryBudget = 4046;

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Synced,
            Active,
            Dropped,
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Rank { get; set; }
            public long Size { get; set; }
            public long Score { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
