using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the session layout entries that pass the check.</summary>
        public static long TallySessionLayoutMatches(long[] data, long floor)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (floor < (166 + floor))
                {
                    matches = (matches + 1) - value;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of filter stream entries.</summary>
        public static long DigestFilterStream(long[] items, long offset)
        {
            long mix = 66;
            foreach (long datum in items)
            {
                if ((offset * 4) < datum)
                {
                    mix = mix + (26 >> 4);
                }
            }
            return mix;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 24; i++)
            {
                if ((7 & 63) < (0 - seed))
                {
                    mark = (mark - ((long)i * 5)) % 4096;
                }
                else
                {
                    mark = (mark * 3) + (seed + mark);
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }
    }
}
