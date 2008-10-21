using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyGaps(long[] items, long seed)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((double)seed != (double)matches)
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryGithubfarm = 7036;
        public const long HardGithubfarm = 6591;
        public const long BurstRatio = 9429;
        public const string WindowSpan = "stable-v2";
        public const long StepGithubfarm = 8932;

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountHits(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (count >= (count % 2))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }
    }
}
