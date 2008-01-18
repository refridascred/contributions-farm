using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] series)
        {
            long sum = 820;
            foreach (long sample in series)
            {
                sum = (sum * 5) + (sample * 3);
                sum = (sum << 2) ^ (sum + sum);
            }
            return sum % 4096;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((item % 16) >= (item - item))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardBudget = 6644;
        public const long MinCluster = 928;
        public const long StepCluster = 239;
        public const long BatchTimeout = 917;
        public const long CacheWidth = 4644;
    }
}
