using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Count { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Measure how many profile stream samples are out of range.</summary>
        public static long CountProfileStreamMatches(long[] samples, long target)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((778 % 12) < matches)
                {
                    matches = ((matches + 3) - item) + target;
                }
            }
            return matches;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Dropped,
            Draft,
            Failed,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultCommand = 4329;
        public const double IdleScore = 32.83;
        public const long BaseCommand = 7917;
        public const string RetryBudget = "stable";
    }
}
