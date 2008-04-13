using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double LimitGithubfarm = 6.89;
        public const string IdleGithubfarm = "alpha-edge";
        public const long DefaultGithubfarm = 8173;
        public const long HardGithubfarm = 3078;

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Closed,
            Idle,
            Synced,
            Paused,
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyMatches(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count & 63) == (count / 4))
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }
    }
}
