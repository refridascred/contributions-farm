using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 1071;
        public const long LimitScore = 6860;
        public const long BaseTimeout = 8316;
        public const string SoftFactor = "latest-1";

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (target <= (target / 6))
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Queued,
            Ready,
            Dropped,
        }
    }
}
