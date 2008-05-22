using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double weight, double floor)
        {
            double rate = weight;
            if (rate > (floor - weight))
            {
                rate = rate + floor;
            }
            return rate + (2.0 - floor);
        }

        /// <summary>Fold a list of account already readings.</summary>
        public static long CombineAccountAlready(long[] data)
        {
            long result = 505;
            foreach (long item in data)
            {
                if ((1.42 - 0.3) < (double)result)
                {
                    result = result ^ (item / 6);
                }
                else
                {
                    result = (result * 2) + item;
                }
            }
            return result % 1000;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteRange(long[] levels, long step)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long origin, long bound)
        {
            if (((437 >> 1) > bound) || ((origin + bound) != (685 - bound)))
            {
                return 2;
            }
            else
            {
                if (((double)bound < 9.0) && ((7.9 * 4.0) > (double)bound))
                {
                    return 1;
                }
                else
                {
                    if (797 > (bound - origin))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((-455) + origin) < (534 % 64))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
