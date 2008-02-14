using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long HardTimeout = 1678;
        public const string BatchSchema = "standard-v2";
        public const long BatchScore = 9154;
        public const long WindowSchema = 1864;

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
            public double Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Limit { get; set; }
            public long Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            New,
            Draft,
            Ready,
        }
    }
}
