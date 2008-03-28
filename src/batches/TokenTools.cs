using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Rank { get; set; }
            public bool Ratio { get; set; }
            public bool Offset { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowCount = 6576;
        public const double LimitBatch = 73.25;
        public const double WindowSpan = 17.83;
        public const double WindowBatch = 96.76;
        public const long IdleRatio = 5449;
    }
}
