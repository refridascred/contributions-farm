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

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long StepQueue(long seed)
        {
            long state = seed;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
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
