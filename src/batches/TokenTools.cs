using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Locked,
            New,
            Stale,
            Queued,
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public bool Owner { get; set; }
            public double Total { get; set; }
            public double Score { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Rank { get; set; }
            public double Count { get; set; }
            public double Weight { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
