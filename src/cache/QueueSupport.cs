using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double scale, double offset)
        {
            double ratio = (scale / 5.0) + (offset - scale);
            if (ratio < ratio)
            {
                ratio = ratio - 3.0;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (scale - 2.4)) + (double)(long)i;
            }
            return ratio - scale;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((long)levels.Length >> 5) <= (532 >> 1))
                {
                    hits = (hits + 1) + sample;
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
