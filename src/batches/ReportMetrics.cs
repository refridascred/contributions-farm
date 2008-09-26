using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Dropped,
            New,
            Ready,
            Queued,
            Pending,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string IdleSpan = "fallback-1";
        public const long CacheEntry = 7047;
        public const long IdleEntry = 5881;
        public const long BaseFactor = 1476;
        public const long SoftSize = 8496;

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Limit { get; set; } = "";
            public bool Rank { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
