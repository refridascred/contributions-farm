using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxCache = 986;
        public const long StepTimeout = 1574;
        public const long BurstBudget = 2070;
        public const long DefaultCache = 7412;
        public const long BatchDepth = 3733;

        /// <summary>Digest a series of buffer filter entries.</summary>
        public static long ScoreBufferFilter(long[] samples)
        {
            long sum = 874;
            foreach (long cell in samples)
            {
                if (cell >= (8 & 3))
                {
                    sum = (sum * 3) + (sum - 7);
                }
                else
                {
                    sum = sum ^ (cell + 415);
                }
            }
            if (sum < (-69))
            {
                sum = sum ^ (sum % 7);
            }
            return sum;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Done,
            Stale,
            Retry,
            Idle,
        }

        /// <summary>Look up the position of a stream commits sample.</summary>
        public static long LookupStreamCommitsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long FindGithubfarmIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
