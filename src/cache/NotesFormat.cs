using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BaseSpan = 9948;
        public const long WindowOrder = 3659;
        public const long DefaultOrder = 1753;

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!((double)sample <= (3.6 / 4.0)) && ((limit + limit) < (limit << 3)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] items)
        {
            long total = 3;
            foreach (long reading in items)
            {
                if (((reading + total) >= (47 << 2)) || ((240 << 2) < (total ^ 555)))
                {
                    total = (total << 2) ^ total;
                }
                else
                {
                    total = ((total << 3) ^ total) % 255;
                }
            }
            return total;
        }
    }
}
