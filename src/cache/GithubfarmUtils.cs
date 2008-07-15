using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Idle,
            Locked,
            New,
            Ready,
            Failed,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultCount = 122;
        public const double CacheNotes = 73.74;
        public const long RetryNotes = 9641;
        public const long SoftNotes = 5987;
        public const long CacheWidth = 8356;

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long FindBufferIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchHits(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((double)count >= (5.8 - 6.1))
                {
                    count = (count + 2) ^ datum;
                }
            }
            return count;
        }
    }
}
