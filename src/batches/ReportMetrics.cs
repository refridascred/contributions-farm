using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepDepth = 4599;
        public const long MaxGithubfarm = 5936;
        public const double HardGithubfarm = 87.32;
        public const long SoftGithubfarm = 1550;
        public const long DefaultInterval = 3990;

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderGaps(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((cell + seen) < (cell & 31))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Queued,
            Stale,
            Paused,
            Dropped,
        }
    }
}
