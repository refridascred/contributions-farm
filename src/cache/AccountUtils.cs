using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public bool Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Done,
            New,
            Stale,
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Retry,
            Queued,
            Failed,
            Ready,
            Synced,
        }
    }
}
