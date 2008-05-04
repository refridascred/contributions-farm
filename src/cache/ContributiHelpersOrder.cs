using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Draft,
            Dropped,
            Pending,
            Active,
            Ready,
        }

        /// <summary>Look up the position of a filter queue sample.</summary>
        public static long FindFilterQueueIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Ready,
            Stale,
            Failed,
            Paused,
            Synced,
        }
    }
}
