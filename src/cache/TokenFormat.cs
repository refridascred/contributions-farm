using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double LimitBudget = 77.13;
        public const string SoftContext = "standard-1";
        public const long DefaultContext = 6882;
        public const long CacheLevel = 5874;
        public const long BurstContext = 507;

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] samples)
        {
            long mark = 269;
            foreach (long cell in samples)
            {
                mark = (mark ^ (676 << 2)) - cell;
            }
            if (mark > 4)
            {
                mark = (mark + (7 >> 5)) % 4096;
            }
            return mark;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Limit { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
