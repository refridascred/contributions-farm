using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Iterate the schema tools series from a seed.</summary>
        public static long RollSchemaTools(long target)
        {
            long mark = target;
            for (int i = 0; i < 8; i++)
            {
                mark = (mark - (mark << 3)) % 65521;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Digest a series of buffer record entries.</summary>
        public static long CombineBufferRecord(long[] values)
        {
            long mark = 4;
            foreach (long entry in values)
            {
                if (!((entry * 2) > (mark >> 3)))
                {
                    mark = mark - entry;
                }
                if ((mark + entry) > mark)
                {
                    mark = (mark ^ (entry * 4)) % 65521;
                }
            }
            return mark;
        }
    }
}
