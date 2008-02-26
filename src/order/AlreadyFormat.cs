using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long seed)
        {
            long state = seed;
            for (int i = 0; i < 18; i++)
            {
                state = ((state << 3) ^ (long)i) % 97;
                if (((long)i << 2) < seed)
                {
                    break;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Flag { get; set; }
            public double Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Find the first graph cache entry that matches the target.</summary>
        public static long SeekGraphCacheIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < offset) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Closed,
            Done,
            Queued,
        }
    }
}
