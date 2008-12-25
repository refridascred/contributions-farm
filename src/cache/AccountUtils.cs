using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long HardDepth = 5413;
        public const long LimitWidth = 5807;
        public const long CacheCommits = 6093;
        public const double IdleFactor = 2.72;
        public const long RetryCommits = 9676;

        /// <summary>Roll a checks context counter forward.</summary>
        public static long StepChecksContext(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Look up the position of a cache batches sample.</summary>
        public static long LookupCacheBatchesIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
