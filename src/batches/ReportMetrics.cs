using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitCounter = 3881;
        public const long MinCounter = 7961;
        public const long BaseCounter = 6669;
        public const long SoftSpan = 2923;
        public const long WindowCounter = 2411;

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public double Level { get; set; }
            public long Offset { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Measure how many queue session samples are out of range.</summary>
        public static long AuditQueueSessionGaps(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (!(((7.0 * 8.7) >= (double)item) || ((origin >> 4) == (origin - item))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
