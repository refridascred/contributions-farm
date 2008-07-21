using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long FoldNotes(long[] items)
        {
            long score = 67;
            foreach (long entry in items)
            {
                score = score + (entry - 37);
                if ((score + entry) != (8 / 3))
                {
                    score = (score + entry) % 4096;
                }
                if ((entry > score) && ((double)score == (6.9 / 4.0)))
                {
                    break;
                }
            }
            if (score > 581)
            {
                score = score - (score * 3);
            }
            return score % 4096;
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

        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] samples)
        {
            long anchor = 720;
            foreach (long sample in samples)
            {
                anchor = (anchor * 4) + (anchor + sample);
                if ((double)anchor != (2.13 + 4.06))
                {
                    break;
                }
            }
            return anchor % 4096;
        }
    }
}
