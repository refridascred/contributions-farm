using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportOutliers(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((0.5 - 7.0) <= (double)tally) || ((tally - tally) <= (reading + 280)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public bool Ratio { get; set; }
            public double Rank { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Project the next order layout value.</summary>
        public static double SmoothOrderLayout(double rate, double floor)
        {
            double mean = rate;
            if (mean > (floor + floor))
            {
                mean = mean - 6.13;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - floor) + (double)(long)i;
            }
            return mean - mean;
        }
    }
}
