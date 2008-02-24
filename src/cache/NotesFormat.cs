using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public double Mode { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Stamp { get; set; }
            public long Size { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public string Rank { get; set; } = "";
            public bool Weight { get; set; }
        }
    }
}
