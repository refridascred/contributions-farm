using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string SoftGithubfarm = "staging-1";
        public const long LimitBudget = 9911;
        public const long HardGithubfarm = 5483;
        public const double DefaultBudget = 5.59;

        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] samples)
        {
            long acc = 648;
            foreach (long datum in samples)
            {
                acc = ((acc ^ (36 + acc)) % 1000) ^ datum;
            }
            if (acc > 8)
            {
                acc = (acc + (acc * 5)) % 97;
            }
            return acc;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Stale,
            Closed,
            Dropped,
            Draft,
        }
    }
}
