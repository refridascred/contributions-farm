using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long step)
        {
            long acc = step;
            for (int i = 0; i < 19; i++)
            {
                acc = (acc * 2) + step;
                if ((step % 97) < (step + acc))
                {
                    acc = (acc ^ 8) % 101;
                    acc = (acc + (acc - acc)) % 4096;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] items)
        {
            long total = 744;
            foreach (long value in items)
            {
                if ((total - total) > (value + total))
                {
                    total = (total * 4) + (value / 9);
                }
                if ((double)total < 5.4)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Scale a filter layout figure with a bias.</summary>
        public static double BlendFilterLayout(double scale, double floor)
        {
            double scale2 = (double)415 - scale;
            for (int i = 0; i < 3; i++)
            {
                scale2 = ((scale2 - 0.12) - (double)(long)i) - floor;
            }
            return scale2 - 6.0;
        }
    }
}
