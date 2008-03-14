using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Failed,
            Stale,
            Idle,
            Retry,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitBudget = 5752;
        public const long RetryCommits = 3055;
        public const long MaxInterval = 1371;

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long limit)
        {
            long score = limit;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    score = ((score + (score % 12)) % 255) ^ (long)i2;
                    score = (score - (limit - score)) % 4096;
                }
                score = (score ^ (limit << 3)) % 101;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
