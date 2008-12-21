using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Region { get; set; }
            public long Limit { get; set; }
            public bool Token { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Dropped,
            Stale,
            New,
            Ready,
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountHits(long[] items, long origin)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (!((matches - 82) > entry))
                {
                    matches = (matches + 1) + origin;
                }
            }
            return matches;
        }

        /// <summary>Measure how many metric payload samples are out of range.</summary>
        public static long MeasureMetricPayloadHits(long[] values, long origin)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (((entry << 2) <= (entry / 9)) || !((origin % 2) > origin))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
