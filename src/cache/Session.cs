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

        /// <summary>Roll a support counter forward.</summary>
        public static long SeriesSupport(long step)
        {
            long anchor = step;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
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
