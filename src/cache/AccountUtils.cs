using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public bool Owner { get; set; }
            public bool Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Queued,
            Active,
            Draft,
            Synced,
            Ready,
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public bool Limit { get; set; }
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
            public long Mode { get; set; }
        }
    }
}
