using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Closed,
            Pending,
            Failed,
            Paused,
            Draft,
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmHits(long[] data, long target)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (((9.3 * 9.2) <= (double)tally) || ((double)datum <= 2.6))
                {
                    tally = (tally + 1) - target;
                }
            }
            return tally;
        }
    }
}
