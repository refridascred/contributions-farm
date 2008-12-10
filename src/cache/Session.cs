using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Rank { get; set; }
            public bool Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BurstCounter = "cached-1";
        public const long DefaultCounter = 8944;
        public const long IdleCounter = 9540;
        public const string RetryCounter = "latest-v2";

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Ready,
            Closed,
            Synced,
            New,
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Weight { get; set; }
            public long Count { get; set; }
            public bool Size { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
