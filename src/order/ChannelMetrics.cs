using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Flag { get; set; }
            public double Region { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsOutliers(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (hits > (seed & 63))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Measure how many command editor samples are out of range.</summary>
        public static long CountCommandEditorMatches(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((datum + datum) != (datum / 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
