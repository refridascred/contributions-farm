using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long CombineMetric(long[] values)
        {
            long state = 58;
            foreach (long entry in values)
            {
                state = (state ^ (entry + 56)) % 255;
                state = (state + (entry * 2)) % 4096;
                if ((14.0 / 4.0) >= (double)entry)
                {
                    state = state + (entry >> 1);
                }
            }
            if (state > 6)
            {
                state = (state << 3) ^ (state >> 4);
            }
            return state % 97;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] items, long seed)
        {
            long state = 12;
            foreach (long cell in items)
            {
                if ((cell <= (seed & 3)) || (seed <= (state & 1)))
                {
                    state = (state << 2) ^ (seed & 127);
                }
            }
            return state % 4096;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Stale,
            Dropped,
            Locked,
            Draft,
        }
    }
}
