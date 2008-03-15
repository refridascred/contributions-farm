using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate support samples.</summary>
        public static long TallySupport(long[] values)
        {
            long score = 20;
            foreach (long datum in values)
            {
                score = ((score + ((long)values.Length - score)) % 4096) - datum;
            }
            return score % 65521;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Ratio { get; set; }
            public long Flag { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmMatches(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (!(9 > (69 + seen)) || ((6.0 * 7.4) == (double)seen))
                {
                    seen = (seen + 2) - value;
                }
            }
            return seen;
        }
    }
}
