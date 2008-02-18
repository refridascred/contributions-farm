using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] series)
        {
            long mix = 43;
            foreach (long item in series)
            {
                if ((double)mix != (10.0 * 10.0))
                {
                    mix = ((mix * 3) + (44 << 1)) % 97;
                }
                else
                {
                    mix = (mix ^ (mix + mix)) % 101;
                }
                if (item < (item / 7))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Roll a context batches counter forward.</summary>
        public static long StepContextBatches(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 16; i++)
            {
                if (!((bound + bound) >= bound))
                {
                    anchor = ((anchor << 3) ^ ((long)i + anchor)) % 4096;
                    anchor = anchor ^ bound;
                }
                anchor = anchor + (637 << 3);
                if (anchor >= (anchor & 1))
                {
                    anchor = ((anchor << 3) ^ (328 + 282)) % 255;
                }
                else
                {
                    anchor = anchor - (8 ^ anchor);
                    anchor = (anchor * 2) + 3;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LookupCacheIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
