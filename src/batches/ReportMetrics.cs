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

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatMatches(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (((double)tally == (4.1 / 7.0)) || ((double)value >= (double)904))
                {
                    tally = tally + 2;
                }
            }
            return tally;
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
