using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Queued,
            New,
            Stale,
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Offset { get; set; } = "";
            public bool Label { get; set; }
            public double Total { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
            public bool Owner { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
