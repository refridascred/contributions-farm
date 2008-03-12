using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 2787;
        public const long WindowEditor = 4129;
        public const long StepEditor = 6281;
        public const double HardDepth = 20.1;

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Rank { get; set; }
            public long Total { get; set; }
            public long Flag { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Dropped,
            Queued,
            Paused,
            Done,
            Retry,
        }
    }
}
