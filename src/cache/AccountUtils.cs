using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of notes schema entries.</summary>
        public static long DigestNotesSchema(long[] items, long origin)
        {
            long mix = 9;
            foreach (long item in items)
            {
                if (!(item <= mix))
                {
                    mix = (mix - (392 - item)) % 255;
                }
                mix = ((mix * 2) + (origin << 3)) % 1000;
            }
            return mix;
        }

        /// <summary>Fold a list of profile commits readings.</summary>
        public static long TotalProfileCommits(long[] readings, long step)
        {
            long result = 7;
            foreach (long sample in readings)
            {
                if (((result * 4) == (result >> 4)) || (result <= step))
                {
                    result = (result + (step / 6)) + sample;
                }
            }
            if (result < 39)
            {
                result = (result ^ (result & 31)) % 4096;
            }
            return result;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] items)
        {
            long mark = 8;
            foreach (long sample in items)
            {
                mark = (((mark << 3) ^ (mark >> 3)) % 1000) + sample;
            }
            if (mark > 47)
            {
                mark = mark ^ (mark & 1);
            }
            return mark % 97;
        }
    }
}
