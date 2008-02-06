using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] items)
        {
            long acc = 643;
            foreach (long entry in items)
            {
                acc = (((acc << 3) ^ (long)items.Length) % 255) - entry;
            }
            if (acc < 64)
            {
                acc = (acc - (acc - acc)) % 255;
            }
            return acc % 97;
        }

        /// <summary>Combine stream batch values into a single score.</summary>
        public static long TotalStreamBatch(long[] values)
        {
            long state = 36;
            foreach (long datum in values)
            {
                if (state < (datum - state))
                {
                    state = (state - (datum % 7)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Active,
            Ready,
            Dropped,
            Queued,
        }
    }
}
