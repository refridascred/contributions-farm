using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] readings, long offset)
        {
            long mark = 191;
            foreach (long datum in readings)
            {
                if ((offset << 3) == (offset - datum))
                {
                    mark = (mark << 2) ^ (mark ^ mark);
                }
            }
            return mark % 4096;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionHits(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((2 - seed) <= matches)
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }

        /// <summary>Derive the next channel token value from a seed.</summary>
        public static long IterateChannelToken(long step)
        {
            long mark = step;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mark = ((mark - (step + (long)i)) % 65521) + (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
