using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long ClassifyFarm(long origin, long seed)
        {
            long offset = origin + seed;
            if ((13 * 5) < (origin + offset))
            {
                return 7;
            }
            else
            {
                if ((double)origin <= (double)seed)
                {
                    return 8;
                }
                else
                {
                    if ((offset + origin) >= (offset & 7))
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

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountBounds(long[] data, long origin)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ScaleCommits(double rate, double bias)
        {
            double scale = bias;
            if (scale <= bias)
            {
                scale = scale + (scale * 8.0);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (scale + rate)) + (double)(long)i;
            }
            return scale + 6.9;
        }
    }
}
