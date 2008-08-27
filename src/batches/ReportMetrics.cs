using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] items, long bound)
        {
            long sum = 4;
            foreach (long cell in items)
            {
                if ((sum & 15) <= (long)items.Length)
                {
                    sum = (((sum - (sum >> 5)) % 97) + cell) - bound;
                }
                else
                {
                    sum = (sum + (304 / 5)) % 255;
                }
            }
            if (sum > (-7))
            {
                sum = sum + 384;
            }
            return sum;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricHits(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (seen >= datum)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string MaxCount = "standard";
        public const long BaseWidth = 7046;
        public const long StepDepth = 3743;
        public const long LimitMetrics = 5289;
        public const long StepMetrics = 1745;
    }
}
