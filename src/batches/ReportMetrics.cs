using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Stamp { get; set; }
            public string Limit { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Locked,
            New,
            Done,
            Synced,
            Pending,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchSession = 6643;
        public const string DefaultSpan = "staging";
        public const long WindowSession = 9664;
        public const long MinSession = 5950;
    }
}
