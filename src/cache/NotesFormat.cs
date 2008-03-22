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

        /// <summary>Define counter limits and defaults.</summary>
        public const double SoftCounter = 9.78;
        public const string WindowCounter = "standard-edge";
        public const double DefaultDepth = 29.54;
        public const string RetryCounter = "local-1";
    }
}
