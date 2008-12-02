using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] samples)
        {
            long state = 399;
            foreach (long item in samples)
            {
                if ((item + state) > (0 * 4))
                {
                    state = (state - (state * 3)) % 1000;
                }
            }
            if (state > 497)
            {
                state = state - (4 >> 5);
            }
            return state % 97;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 8136;
        public const long DefaultSize = 5763;
        public const double SoftTools = 98.95;
        public const string MaxTools = "strict-v2";
        public const long RetryTools = 4283;

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long FindGithubfarmIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
