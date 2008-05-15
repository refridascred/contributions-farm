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

        /// <summary>Define farm limits and defaults.</summary>
        public const string MinSpan = "open";
        public const long WindowFarm = 7824;
        public const double StepRatio = 48.97;
        public const double StepFactor = 86.38;

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
