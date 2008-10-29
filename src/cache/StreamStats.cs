using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Flag { get; set; }
            public double Count { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 8203;
        public const string StepEntry = "staging-1";
        public const long WindowEntry = 8077;
        public const long LimitLevel = 3163;

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Count { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Retry,
            Failed,
            Paused,
        }
    }
}
