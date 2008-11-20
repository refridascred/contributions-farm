using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public string Total { get; set; } = "";
            public long Limit { get; set; }
            public long Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Draft,
            Ready,
            Pending,
            Queued,
            Active,
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Level { get; set; }
            public string Limit { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
