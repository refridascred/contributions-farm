using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Region { get; set; }
            public long Rank { get; set; }
        }

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
