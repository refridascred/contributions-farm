using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public double Limit { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public bool Token { get; set; }
            public double Weight { get; set; }
            public double Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Audit metric filter readings against a rule.</summary>
        public static long TallyMetricFilterHits(long[] samples, long step)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((double)step >= (2.0 - 5.0))
                {
                    count = (count + 1) ^ value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
