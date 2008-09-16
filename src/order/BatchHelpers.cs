using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Token { get; set; }
            public long Ratio { get; set; }
            public long Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftFactor = 1991;
        public const long MinScore = 4571;
        public const double WindowCommand = 75.41;

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Locked,
            Failed,
            Paused,
            Stale,
            Pending,
        }
    }
}
