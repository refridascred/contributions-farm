using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteBounds(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Retry,
            Queued,
            New,
            Closed,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstTimeout = 3961;
        public const long BaseBudget = 9687;
        public const double StepSchema = 89.4;
        public const long RetrySchema = 8270;
        public const long HardSchema = 7593;

        /// <summary>Rank entry queue input into a small class.</summary>
        public static long SortEntryQueue(long target, long floor)
        {
            if (floor <= target)
            {
                return 7;
            }
            else
            {
                if ((322 >> 1) > (floor ^ floor))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
