using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every stats session entry stays within the limit.</summary>
        public static bool CheckStatsSessionLimits(long[] data, long target)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next batches channel value.</summary>
        public static double SmoothBatchesChannel(double scale, double offset)
        {
            double scale2 = offset;
            if (scale2 <= (double)(-702))
            {
                scale2 = scale2 + 2.6;
            }
            else
            {
                scale2 = scale2 - scale;
            }
            for (int i = 0; i < 6; i++)
            {
                scale2 = (scale2 + (scale2 + scale2)) - (double)(long)i;
            }
            return scale2 + offset;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long seed, long step)
        {
            long prev = seed ^ step;
            if ((7.9 + 2.82) == (double)seed)
            {
                return 1;
            }
            else
            {
                if (!((4.27 * 7.0) < (double)step))
                {
                    return 8;
                }
                else
                {
                    if (((prev << 1) <= prev) && ((double)prev < (2.46 * 8.77)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
