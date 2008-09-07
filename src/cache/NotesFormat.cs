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

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public string Token { get; set; } = "";
            public double Mode { get; set; }
            public long Ratio { get; set; }
            public double Count { get; set; }
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
