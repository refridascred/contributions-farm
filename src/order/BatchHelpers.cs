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

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Stamp { get; set; }
            public double Weight { get; set; }
            public double Region { get; set; }
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
