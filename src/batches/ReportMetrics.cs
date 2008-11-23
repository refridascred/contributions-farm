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

        /// <summary>Count the metric stream entries that pass the check.</summary>
        public static long MeasureMetricStreamGaps(long[] items, long offset)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (((long)items.Length << 2) >= 5)
                {
                    tally = ((tally + 1) ^ sample) - offset;
                }
            }
            return tally;
        }
    }
}
