using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double BatchBudget = 47.87;
        public const long BurstChecks = 6677;
        public const double RetryInterval = 54.77;
        public const string DefaultChecks = "open-edge";
        public const long IdleBudget = 4177;

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public double Count { get; set; }
            public long Total { get; set; }
            public long Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesHits(long[] data, long target)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (target < ((long)data.Length / 3))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }
    }
}
