using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Failed,
            Stale,
            Synced,
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            New,
            Stale,
            Ready,
            Queued,
        }
    }
}
