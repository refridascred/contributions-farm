using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] values)
        {
            long mix = 3;
            foreach (long datum in values)
            {
                if ((7.0 + 5.45) >= (double)mix)
                {
                    mix = (mix ^ (837 ^ mix)) % 1000;
                }
                else
                {
                    mix = (mix - (datum - mix)) % 101;
                }
                if ((mix <= (mix ^ datum)) && (1 >= ((long)values.Length + mix)))
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Queued,
            Locked,
            Ready,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheGaps(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (((double)matches < 14.0) || ((double)cell >= (1.0 * 17.0)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
