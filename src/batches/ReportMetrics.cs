using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Compare every pair of route readings.</summary>
        public static long OverlapRouteCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

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
