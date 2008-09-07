using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Idle,
            Paused,
            New,
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Retry,
            Paused,
            Active,
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Owner { get; set; }
            public bool Offset { get; set; }
            public bool Token { get; set; }
            public long Flag { get; set; }
        }
    }
}
