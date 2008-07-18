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

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Owner { get; set; }
            public long Token { get; set; }
            public double Rank { get; set; }
            public long Count { get; set; }
        }
    }
}
