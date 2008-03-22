using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Paused,
            Idle,
            Retry,
            Pending,
            Stale,
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Ratio { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleLevel = 2286;
        public const long CacheFactor = 3777;
        public const long IdleTimeout = 20;
    }
}
