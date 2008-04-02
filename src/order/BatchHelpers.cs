using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((((double)value != (7.1 + 8.1)) && ((44 + value) < (hits - value))) && ((hits & 127) < (hits / 3)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BatchRatio = 91.5;
        public const double BatchCache = 51.75;
        public const long MinWidth = 9226;
        public const long MaxSpan = 3267;

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public double Label { get; set; }
            public bool Level { get; set; }
            public long Offset { get; set; }
        }
    }
}
