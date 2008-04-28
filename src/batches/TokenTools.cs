using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public string Token { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Ratio { get; set; }
            public long Level { get; set; }
            public bool Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public bool Rank { get; set; }
            public long Offset { get; set; }
            public double Mode { get; set; }
        }
    }
}
