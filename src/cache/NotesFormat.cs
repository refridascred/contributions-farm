using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Dropped,
            Locked,
            New,
            Synced,
            Pending,
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long origin)
        {
            long state = origin;
            for (int i = 0; i < 24; i++)
            {
                if ((origin & 15) >= (long)i)
                {
                    state = (state * 2) + (origin << 3);
                }
                else
                {
                    state = (state + (state - state)) % 255;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesBounds(long[] items, long bound)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
