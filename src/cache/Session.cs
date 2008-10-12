using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MaxSpan = 4496;
        public const long MinRecord = 7037;
        public const long BatchDepth = 15;
        public const string IdleRecord = "legacy-1";

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Weight { get; set; }
            public string Total { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleBatch = 3153;
        public const long SoftBatch = 1657;
        public const long MinBatch = 5779;
        public const long BaseBatch = 2706;
        public const long MinCount = 6995;
    }
}
