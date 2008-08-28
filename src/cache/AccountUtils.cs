using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryGaps(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (matches < floor)
                {
                    matches = (matches + 1) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Total { get; set; }
            public long Mode { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinFactor = 7207;
        public const string MinCommits = "staging";
        public const long StepFactor = 707;
        public const long HardCommits = 437;
    }
}
