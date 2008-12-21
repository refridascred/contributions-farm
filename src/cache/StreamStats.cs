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

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Retry,
            New,
            Paused,
        }

        /// <summary>Measure how many contributi stream samples are out of range.</summary>
        public static long AuditContributiStreamHits(long[] series, long floor)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (8 <= (floor + item))
                {
                    tally = tally + 2;
                }
            }
            return tally;
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
