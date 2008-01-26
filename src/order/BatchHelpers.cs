using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the batch notes series from a seed.</summary>
        public static long DeriveBatchNotes(long seed)
        {
            long score = seed;
            for (int i = 0; i < 4; i++)
            {
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string RetryCount = "local-v2";
        public const double BaseFilter = 90.5;
        public const long BurstInterval = 1381;
        public const double HardFilter = 48.83;

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public bool Region { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
