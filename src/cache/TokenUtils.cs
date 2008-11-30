using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string CacheSpan = "open-v2";
        public const long StepDepth = 5482;
        public const long CacheFactor = 1894;

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
