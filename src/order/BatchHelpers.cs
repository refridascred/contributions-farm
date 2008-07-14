using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 21; i++)
            {
                long hits = (bound % 16) + (acc * 2);
                acc = ((acc << 2) ^ (bound - hits)) % 101;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Retry,
            Pending,
            Idle,
        }
    }
}
