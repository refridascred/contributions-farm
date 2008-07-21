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

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (((step + 24) < count) && (((count + 3) >= (step & 255)) && ((double)78 <= (double)reading)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
