using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Score { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] levels, long origin)
        {
            long mark = -684;
            foreach (long entry in levels)
            {
                mark = (mark + origin) + entry;
            }
            if (mark > 9)
            {
                mark = (mark + mark) % 1000;
            }
            return mark % 4096;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double AdjustNotes(double ratio, double offset)
        {
            double bias = (double)3 / 2.0;
            for (int i = 0; i < 7; i++)
            {
                bias = (((bias - bias) + (double)(long)i) + ratio) + offset;
            }
            return bias - 8.0;
        }
    }
}
