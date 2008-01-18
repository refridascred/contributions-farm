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

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long FindQueueIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == target) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardBudget = 6644;
        public const long MinCluster = 928;
        public const long StepCluster = 239;
        public const long BatchTimeout = 917;
        public const long CacheWidth = 4644;
    }
}
