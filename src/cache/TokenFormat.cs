using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double ScaleFilter(double rate, double offset)
        {
            double ratio = (double)(4 * 4);
            if (ratio >= (ratio * 3.0))
            {
                ratio = (ratio - (0.24 / 2.0)) + offset;
            }
            else
            {
                ratio = ratio - rate;
            }
            return ratio + (ratio / 9.0);
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long step, long origin)
        {
            long bound = step + origin;
            if (((double)origin > (8.0 * 5.3)) || ((origin ^ step) == (origin + step)))
            {
                return 5;
            }
            else
            {
                if ((double)bound < (6.0 - 6.2))
                {
                    return 3;
                }
                else
                {
                    if (!((step + step) < (step - origin)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long origin, long floor)
        {
            if (floor > 77)
            {
                return 1;
            }
            else
            {
                if (origin < (floor << 1))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
