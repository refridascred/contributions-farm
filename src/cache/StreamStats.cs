using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Failed,
            Synced,
            Queued,
            Idle,
            Ready,
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public bool Stamp { get; set; }
            public string Limit { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepRatio = 8778;
        public const long SoftSession = 1536;
        public const long StepSpan = 187;
        public const long DefaultScore = 9051;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 432;
        public const long HardBuffer = 6379;
        public const long IdleRatio = 8222;
    }
}
