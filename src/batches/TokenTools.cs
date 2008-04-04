using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a window reading.</summary>
        public static double SmoothWindow(double rate, double span)
        {
            double ratio = (double)177 - 9.0;
            if (ratio > span)
            {
                ratio = (ratio - (double)803) + rate;
            }
            else
            {
                ratio = ratio - ratio;
            }
            return ratio - ratio;
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

        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long target, long origin)
        {
            if (!((target / 8) <= (target - origin)))
            {
                return 4;
            }
            else
            {
                if ((target << 2) < target)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
