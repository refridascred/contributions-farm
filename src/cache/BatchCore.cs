using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double BurstSchema = 77.49;
        public const string SoftScore = "latest-1";
        public const double BatchSchema = 80.44;
        public const double LimitSchema = 48.13;

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
