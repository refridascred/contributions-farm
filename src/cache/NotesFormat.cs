using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] items, long target)
        {
            long state = 32;
            foreach (long sample in items)
            {
                state = ((state - (state ^ target)) % 97) ^ sample;
            }
            if (state < 122)
            {
                state = (state * 4) + (target - state);
            }
            return state % 4096;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Region { get; set; }
            public bool Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Combine notes window values into a single score.</summary>
        public static long FoldNotesWindow(long[] data, long offset)
        {
            long mark = 985;
            foreach (long value in data)
            {
                mark = ((mark ^ offset) % 97) + value;
            }
            if (mark < 91)
            {
                mark = (mark ^ (mark - mark)) % 97;
            }
            return mark;
        }
    }
}
