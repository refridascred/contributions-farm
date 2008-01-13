using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long SeriesRoute(long seed)
        {
            long total = seed;
            for (int i = 0; i < 15; i++)
            {
                total = total + (seed / 8);
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long DeriveSchema(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 12; i++)
            {
                mark = (mark << 2) ^ (origin << 1);
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
