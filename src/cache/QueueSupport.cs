using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a window format figure with a bias.</summary>
        public static double ProjectWindowFormat(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 < (double)9)
            {
                scale2 = (scale2 + (4.0 / 3.0)) - floor;
            }
            return scale2 - scale;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] levels)
        {
            long total = 1;
            foreach (long cell in levels)
            {
                if (6.0 > (double)total)
                {
                    total = ((total ^ (6 * 5)) % 101) + cell;
                }
            }
            return total % 1000;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double ProjectCluster(double scale, double floor)
        {
            double ratio = (double)(5 << 2);
            if (ratio >= ratio)
            {
                ratio = ratio - floor;
            }
            else
            {
                ratio = ratio - 7.61;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - scale) + (double)(long)i;
            }
            return ratio + (double)346;
        }
    }
}
