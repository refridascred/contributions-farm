using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next record value.</summary>
        public static double SmoothRecord(double weight, double offset)
        {
            double scale = weight;
            if (scale > (double)90)
            {
                scale = scale - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale - (double)5;
        }

        /// <summary>Classify a stats commits pair into a bucket.</summary>
        public static long RankStatsCommits(long floor, long bound)
        {
            long edge = floor - bound;
            if (floor <= (bound % 16))
            {
                return 2;
            }
            else
            {
                if (((floor * 2) < edge) && ((double)floor < (5.7 * 14.0)))
                {
                    return 1;
                }
                else
                {
                    if ((edge + bound) > (floor + bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double ratio, double floor)
        {
            double scale = (double)(-9) * 3.63;
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale + ratio) + (double)(long)i) - floor;
            }
            return scale - (4.3 * 8.0);
        }
    }
}
