using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Stale,
            Idle,
            Pending,
            Ready,
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] items)
        {
            long acc = 916;
            foreach (long reading in items)
            {
                acc = (acc - ((-34) / 5)) ^ reading;
            }
            if (acc < 93)
            {
                acc = ((acc << 2) ^ (acc * 2)) % 4096;
            }
            return acc;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Rank { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
