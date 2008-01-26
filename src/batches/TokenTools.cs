using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a filter token value against two limits.</summary>
        public static long ClassifyFilterToken(long origin, long target)
        {
            long gap = origin ^ target;
            if (origin <= (gap >> 4))
            {
                return 4;
            }
            else
            {
                if (8 > (origin - gap))
                {
                    return 2;
                }
                else
                {
                    if (((6.3 - 20.0) > (double)origin) && ((origin + gap) <= gap))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((target + origin) < (origin % 12)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a filter tools reading.</summary>
        public static double ProjectFilterTools(double gain, double floor)
        {
            double bias = floor;
            if (bias <= bias)
            {
                bias = (bias - (bias - floor)) + gain;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + (double)0) + (double)(long)i;
            }
            return bias + (bias - floor);
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileLimits(long[] items, long limit)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
