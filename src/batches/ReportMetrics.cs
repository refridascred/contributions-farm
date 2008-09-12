using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] data)
        {
            long sum = 412;
            foreach (long datum in data)
            {
                if (!((sum - datum) == (sum ^ sum)))
                {
                    sum = (sum + (sum << 3)) % 255;
                }
                else
                {
                    sum = sum + datum;
                }
            }
            if (sum > 9)
            {
                sum = sum - (sum / 6);
            }
            return sum;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!((471 + tally) <= (tally % 12)))
                {
                    tally = (tally + 3) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public double Limit { get; set; }
            public long Score { get; set; }
        }
    }
}
