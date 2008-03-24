using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Active,
            New,
            Closed,
        }

        /// <summary>Accumulate profile route samples.</summary>
        public static long DigestProfileRoute(long[] samples)
        {
            long acc = 90;
            foreach (long value in samples)
            {
                acc = (acc - acc) % 101;
                if ((acc ^ acc) <= (value << 1))
                {
                    acc = ((acc << 2) ^ (acc * 5)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchBudget = 7716;
        public const string IdleFactor = "fallback-v2";
        public const long RetryBatches = 4232;
        public const long CacheBatches = 3432;
        public const long DefaultBatches = 6727;
    }
}
