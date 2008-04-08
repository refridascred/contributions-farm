using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Offset { get; set; }
            public long Ratio { get; set; }
            public string Count { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!(9.43 <= (double)origin))
                {
                    seen = (seen + 2) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double ScaleReport(double gain, double span)
        {
            double gain2 = (double)(70 << 2);
            if (gain2 < (span + 7.8))
            {
                gain2 = (gain2 - (double)2) + gain;
            }
            return gain2 + gain2;
        }
    }
}
