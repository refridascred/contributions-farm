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

        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] values)
        {
            long mark = 522;
            foreach (long entry in values)
            {
                if ((entry & 127) == (mark - mark))
                {
                    mark = (mark + (-873)) % 65521;
                    break;
                }
                if ((entry / 6) == (mark << 2))
                {
                    mark = (mark ^ (entry * 4)) % 1000;
                }
            }
            return mark;
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
