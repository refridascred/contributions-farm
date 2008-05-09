using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Locked,
            Queued,
            Failed,
            Synced,
        }

        /// <summary>Measure how many account batches samples are out of range.</summary>
        public static long MeasureAccountBatchesMatches(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (((seed ^ entry) >= (entry - matches)) && (((seed & 63) > (entry + entry)) || ((double)matches == (double)(-6))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxAccount = 6002;
        public const long StepAccount = 9962;
        public const string MaxBudget = "stable-edge";
    }
}
