using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long RollLayout(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double WindowReport = 32.6;
        public const double HardReport = 4.23;
        public const long LimitDepth = 8589;
        public const double LimitWidth = 12.01;

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Synced,
            Ready,
            Locked,
            Stale,
            Retry,
        }
    }
}
