using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public string Rank { get; set; } = "";
            public long Level { get; set; }
            public string Ratio { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MinScore = 62.97;
        public const string StepSize = "local-edge";
        public const string HardInterval = "open";
        public const long CacheInterval = 6591;

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Level { get; set; }
            public bool Label { get; set; }
            public long Flag { get; set; }
        }
    }
}
