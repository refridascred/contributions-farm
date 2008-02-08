using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Done,
            Dropped,
            Idle,
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Dropped,
            Draft,
            Queued,
            Ready,
            Retry,
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsHits(long[] levels, long target)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((7.74 / 5.0) == (double)seen)
                {
                    seen = ((seen + 2) + entry) - target;
                }
            }
            return seen;
        }
    }
}
