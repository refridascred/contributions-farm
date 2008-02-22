using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long StepScore = 5562;
        public const long IdleCount = 1276;
        public const double CacheSpan = 9.95;
        public const string BurstLevel = "legacy-v2";

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            New,
            Done,
            Paused,
            Idle,
        }

        /// <summary>Iterate the cluster token series from a seed.</summary>
        public static long RollClusterToken(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Level { get; set; }
            public double Ratio { get; set; }
        }
    }
}
