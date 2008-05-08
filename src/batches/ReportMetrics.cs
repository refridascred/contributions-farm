using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Failed,
            New,
            Pending,
            Stale,
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Limit { get; set; }
            public bool Level { get; set; }
            public long Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Stale,
            Done,
            Idle,
            Failed,
        }
    }
}
