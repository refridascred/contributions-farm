using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public double Stamp { get; set; }
            public double Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long bound)
        {
            long total = bound;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Audit command metrics readings against a rule.</summary>
        public static long AuditCommandMetricsOutliers(long[] data, long limit)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((((83 >> 1) != (sample >> 4)) && (9.13 < (double)limit)) || (seen < (sample << 1)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
