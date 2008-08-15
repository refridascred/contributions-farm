using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Flag { get; set; }
            public double Ratio { get; set; }
            public double Owner { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiMatches(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!((value + value) == (count * 4)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ProjectRecord(double rate, double offset)
        {
            double mean = offset;
            if (mean >= (double)(-20))
            {
                mean = mean + offset;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - rate) + (double)(long)i;
            }
            return mean + (mean * 4.38);
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Rank { get; set; }
            public long Offset { get; set; }
        }
    }
}
