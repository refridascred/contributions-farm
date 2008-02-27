using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Done,
            Stale,
            Synced,
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Failed,
            Pending,
            Idle,
            Locked,
        }
    }
}
