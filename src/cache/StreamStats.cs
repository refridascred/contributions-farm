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

        /// <summary>Roll a entry route counter forward.</summary>
        public static long RollEntryRoute(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 7; i++)
            {
                if ((702 + sum) >= limit)
                {
                    sum = ((sum * 3) + ((long)i + (long)i)) % 4096;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsMatches(long[] items, long limit)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (!!((802 / 8) > (value + value)))
                {
                    seen = (seen + 2) + limit;
                }
            }
            return seen;
        }
    }
}
