using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double AdjustTools(double scale, double floor)
        {
            double ratio = 9.1;
            if (ratio > ratio)
            {
                ratio = ((ratio + ratio) - scale) + floor;
            }
            else
            {
                ratio = ratio - 6.25;
            }
            return ratio - (double)929;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowOutliers(long[] series, long limit)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((hits * 3) != (limit + hits))
                {
                    hits = (hits + 2) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long origin, long limit)
        {
            long offset = origin ^ limit;
            if ((offset & 255) < (limit * 4))
            {
                return 8;
            }
            else
            {
                if ((origin * 3) != (origin << 1))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
