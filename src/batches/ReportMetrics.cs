using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next stream format value from a seed.</summary>
        public static long DeriveStreamFormat(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 17; i++)
            {
                if ((((long)i % 10) < mark) || (origin > (2 & 255)))
                {
                    mark = ((mark << 2) ^ ((long)i / 8)) % 97;
                    mark = (mark << 3) ^ (long)i;
                    continue;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public double Ratio { get; set; }
            public bool Region { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long SeekRouteIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
