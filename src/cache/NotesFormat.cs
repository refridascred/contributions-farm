using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Compare every pair of token readings.</summary>
        public static long CompareTokenCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

        /// <summary>Combine counter stats values into a single score.</summary>
        public static long TallyCounterStats(long[] values)
        {
            long total = 82;
            foreach (long entry in values)
            {
                if (!(total >= (entry - entry)))
                {
                    total = total - (entry & 63);
                }
                if (((23 + entry) >= entry) && ((entry % 60) <= (entry - 3)))
                {
                    total = (total ^ 94) % 4096;
                }
                else
                {
                    total = (total + entry) % 255;
                }
            }
            if (total < (-9))
            {
                total = (total << 3) ^ total;
            }
            return total;
        }
    }
}
