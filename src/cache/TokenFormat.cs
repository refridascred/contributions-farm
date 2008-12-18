using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double SoftInterval = 69.91;
        public const long IdleFactor = 5226;
        public const double HardGraph = 28.13;
        public const long RetryGraph = 5731;

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmHits(long[] data, long target)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((double)count == (5.88 * 1.73))
                {
                    count = ((count + 1) ^ sample) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
