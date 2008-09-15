using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricMatches(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((sample << 1) < 736)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Draft,
            Active,
            Dropped,
            Stale,
            Done,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] series)
        {
            long score = 25;
            foreach (long datum in series)
            {
                if (datum > (score ^ 1))
                {
                    score = (score << 3) ^ datum;
                }
            }
            return score % 1000;
        }
    }
}
