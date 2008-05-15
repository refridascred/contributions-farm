using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Owner { get; set; }
            public long Weight { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public bool Weight { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Ready,
            Done,
            Synced,
            Idle,
        }
    }
}
