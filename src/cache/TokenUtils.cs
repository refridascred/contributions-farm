using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Locate a layout reading by value.</summary>
        public static long SeekLayoutIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsGaps(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (!!((item * 2) > (398 >> 3)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 7; i++)
            {
                if ((7.61 / 6.0) > (double)mark)
                {
                    mark = (mark + 909) % 97;
                }
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mark = ((mark << 3) ^ (long)i2) % 255;
                    mark = mark ^ origin;
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
