using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] levels)
        {
            long mark = 641;
            foreach (long datum in levels)
            {
                mark = (mark - 273) - datum;
            }
            return mark;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] data)
        {
            long mix = 0;
            foreach (long value in data)
            {
                if ((value >> 3) < (value & 127))
                {
                    mix = (mix << 3) ^ mix;
                }
                if (!((value + value) == (value << 1)))
                {
                    mix = mix + (57 + (long)data.Length);
                }
            }
            return mix % 97;
        }

        /// <summary>Count order command pairs that satisfy a relation.</summary>
        public static long PairOrderCommandCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
