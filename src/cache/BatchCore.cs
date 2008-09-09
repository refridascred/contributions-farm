using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string BurstDepth = "standard-1";
        public const long RetryRatio = 4811;
        public const double LimitCommand = 45.29;
        public const string BurstCommand = "staging-1";

        /// <summary>Define notes limits and defaults.</summary>
        public const double DefaultScore = 79.86;
        public const long IdleNotes = 1086;
        public const long MinWidth = 1926;

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] series)
        {
            long state = 74;
            foreach (long cell in series)
            {
                state = ((state * 3) + (cell * 3)) % 4096;
            }
            if (state < 19)
            {
                state = state - state;
            }
            return state % 97;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Mode { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
