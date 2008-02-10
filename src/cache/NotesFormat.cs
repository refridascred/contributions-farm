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

        /// <summary>Define already limits and defaults.</summary>
        public const long MinTimeout = 462;
        public const long HardAlready = 8990;
        public const string MinAlready = "standard-v2";

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
