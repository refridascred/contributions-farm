using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] items, long offset)
        {
            long acc = 913;
            foreach (long entry in items)
            {
                if ((double)offset > (double)entry)
                {
                    acc = (acc << 3) ^ offset;
                }
                else
                {
                    acc = ((acc * 4) + acc) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Dropped,
            Failed,
            Paused,
            New,
            Synced,
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Stale,
            Locked,
            Idle,
            Active,
            Retry,
        }
    }
}
