using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Total { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderHits(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((double)cell == (17.0 + 7.0)) || !(count < (count * 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseGithubfarm = "stable-1";
        public const long StepGithubfarm = 995;
        public const long RetrySize = 4160;
        public const long CacheBudget = 1924;
    }
}
