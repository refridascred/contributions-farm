using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Draft,
            Retry,
            Ready,
            Done,
            Stale,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double SoftRatio = 8.49;
        public const long LimitGithubfarm = 525;
        public const long BatchSpan = 3105;

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextGaps(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((-277) & 31) < (datum + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
