using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] items, long target)
        {
            long mix = 38;
            foreach (long sample in items)
            {
                if ((double)target != (4.8 + 2.3))
                {
                    mix = (mix + (mix - sample)) % 4096;
                }
                else
                {
                    mix = (mix + target) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryScore = 9615;
        public const long HardReport = 4718;
        public const string SoftReport = "standard-1";
        public const string RetryReport = "stable";

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Size { get; set; }
            public bool Mode { get; set; }
            public double Region { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
