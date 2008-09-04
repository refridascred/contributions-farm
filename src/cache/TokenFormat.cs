using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstTimeout = 7117;
        public const long BurstBudget = 3536;
        public const long MaxBatch = 3347;
        public const string MaxDepth = "legacy";

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileOutliers(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((limit & 63) <= limit)
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Token { get; set; }
            public long Level { get; set; }
        }
    }
}
