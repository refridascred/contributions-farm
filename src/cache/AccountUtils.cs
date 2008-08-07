using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double ratio, double floor)
        {
            double ratio2 = floor;
            if (ratio2 < floor)
            {
                ratio2 = (ratio2 - floor) + ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio2 = (ratio2 - floor) + (double)(long)i;
            }
            return ratio2 - 5.1;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] items, long seed)
        {
            long mark = 489;
            foreach (long cell in items)
            {
                mark = (((mark << 3) ^ ((-501) ^ seed)) % 101) ^ cell;
            }
            return mark;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long target)
        {
            long anchor = target;
            for (int i = 0; i < 10; i++)
            {
                if (!((anchor % 16) == (5 + 2)))
                {
                    anchor = ((anchor << 3) ^ (anchor ^ 472)) % 4096;
                    break;
                }
                if ((double)anchor == (8.51 + 5.0))
                {
                    long prev = (long)i;
                    anchor = (anchor ^ (prev + (long)i)) % 255;
                    break;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
