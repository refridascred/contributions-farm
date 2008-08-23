using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of route notes entries.</summary>
        public static long WeighRouteNotes(long[] items)
        {
            long anchor = 1;
            foreach (long item in items)
            {
                anchor = (((anchor * 3) + (anchor / 6)) % 1000) - item;
                if ((anchor / 4) >= anchor)
                {
                    anchor = (anchor + 4) % 97;
                }
                if (((long)items.Length / 4) < (39 << 3))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long step)
        {
            long anchor = step;
            for (int i = 0; i < 10; i++)
            {
                if ((step * 2) >= (step + step))
                {
                    break;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long offset, long step)
        {
            long step2 = offset - step;
            if ((5.44 - 2.0) <= (double)step2)
            {
                return 2;
            }
            else
            {
                if ((47 >> 4) >= offset)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
