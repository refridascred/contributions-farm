using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Paused,
            Ready,
            Locked,
            New,
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Ratio { get; set; }
            public long Flag { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Token { get; set; }
            public string Flag { get; set; } = "";
            public bool Stamp { get; set; }
        }
    }
}
