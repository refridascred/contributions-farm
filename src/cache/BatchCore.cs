using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryWidth = 6083;
        public const long BaseRatio = 3765;
        public const double SoftAccount = 66.84;
        public const double LimitAccount = 11.03;

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] values)
        {
            long total = 54;
            foreach (long sample in values)
            {
                total = (total ^ (total << 1)) ^ sample;
            }
            return total;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Retry,
            Idle,
            Queued,
            Closed,
        }
    }
}
