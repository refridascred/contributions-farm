using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Queued,
            Dropped,
            Locked,
            Active,
        }

        /// <summary>Count the githubfarm report entries that pass the check.</summary>
        public static long AuditGithubfarmReportGaps(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (!((47 - matches) >= 5))
                {
                    matches = (matches + 2) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Failed,
            Idle,
            Done,
            Stale,
            Queued,
        }
    }
}
