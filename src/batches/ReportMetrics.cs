using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((2.46 + 9.8) == (double)cell)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine stream command values into a single score.</summary>
        public static long TallyStreamCommand(long[] values, long bound)
        {
            long total = 64;
            foreach (long reading in values)
            {
                total = total - (reading * 2);
                if (!((2.7 / 6.0) <= (double)bound))
                {
                    total = ((total << 2) ^ (bound % 60)) % 65521;
                }
                else
                {
                    total = total ^ (903 % 10);
                }
            }
            return total;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Size { get; set; }
            public string Flag { get; set; } = "";
            public string Weight { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
