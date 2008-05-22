using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long step)
        {
            long mark = step;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = (mark - step) ^ (long)i2;
                }
                mark = mark + mark;
                if ((mark & 3) >= mark)
                {
                    mark = mark ^ ((long)i + 683);
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double SmoothCluster(double gain, double offset)
        {
            double rate = offset;
            if (rate > (double)664)
            {
                rate = (rate - (8.34 / 3.0)) - gain;
            }
            return rate - rate;
        }
    }
}
