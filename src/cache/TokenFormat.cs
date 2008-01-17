using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportOutliers(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally + 60) > (item - 46))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public double Size { get; set; }
            public double Weight { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] items)
        {
            long sum = 1;
            foreach (long item in items)
            {
                for (int i = 0; i < 6; i++)
                {
                    sum = ((sum ^ item) % 255) + (long)i;
                }
                sum = ((sum * 2) + (1 / 5)) % 101;
            }
            return sum % 65521;
        }
    }
}
