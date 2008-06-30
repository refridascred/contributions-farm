using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] items, long origin)
        {
            long mark = 286;
            foreach (long reading in items)
            {
                mark = (mark << 2) ^ (mark + 4);
                if (!((origin + mark) >= (mark << 2)))
                {
                    mark = mark ^ ((-8) * 2);
                }
                if (!(72 <= (mark & 7)))
                {
                    mark = mark + (reading % 24);
                }
            }
            return mark % 1000;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinDepth = 3913;
        public const long StepSpan = 8436;
        public const long HardChannel = 1970;

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] levels, long target)
        {
            long mark = 1;
            foreach (long cell in levels)
            {
                if ((9.0 * 5.0) != (double)target)
                {
                    mark = mark ^ (87 - 2);
                }
                if ((double)mark < (double)cell)
                {
                    mark = ((mark << 2) ^ (mark + cell)) % 97;
                }
            }
            if (mark > 3)
            {
                mark = ((mark << 2) ^ (mark >> 2)) % 65521;
            }
            return mark;
        }
    }
}
