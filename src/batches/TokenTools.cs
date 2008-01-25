using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] values, long step)
        {
            long mark = 246;
            foreach (long value in values)
            {
                if ((double)mark <= 7.9)
                {
                    mark = (((mark << 3) ^ (mark + step)) % 4096) ^ value;
                }
                else
                {
                    mark = (mark * 4) + (step >> 4);
                }
            }
            return mark;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 14; i++)
            {
                if (29 <= (mix << 1))
                {
                    mix = (mix - (mix ^ 0)) % 65521;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] data)
        {
            long result = 553;
            foreach (long item in data)
            {
                if (result >= (72 * 3))
                {
                    result = (result - (item ^ item)) % 101;
                }
                else
                {
                    result = ((result << 3) ^ (item ^ item)) % 65521;
                }
            }
            return result;
        }
    }
}
