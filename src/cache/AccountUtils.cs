using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double AdjustLayout(double gain, double span)
        {
            double load = span;
            if (load > load)
            {
                load = (load - (double)758) + gain;
            }
            return load - span;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long origin, long step)
        {
            if ((origin - step) >= 11)
            {
                return 4;
            }
            else
            {
                if ((origin ^ origin) <= (715 + origin))
                {
                    return 5;
                }
                else
                {
                    if ((double)step <= (4.08 / 2.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((13 << 1) <= (origin >> 3)) || ((step & 127) >= (step + step)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long floor, long target)
        {
            if ((target - 6) <= (target % 97))
            {
                return 5;
            }
            else
            {
                if (target < (floor - 4))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
