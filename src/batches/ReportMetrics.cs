using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Rank { get; set; }
            public string Level { get; set; } = "";
            public double Token { get; set; }
            public double Owner { get; set; }
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
