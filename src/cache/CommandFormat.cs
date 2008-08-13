using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksBounds(long[] items, long target)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long origin, long offset)
        {
            if (((origin / 6) < (offset + offset)) && (offset >= (19 & 15)))
            {
                return 5;
            }
            else
            {
                if (((origin >> 2) == (offset ^ offset)) || (4 >= (origin - 77)))
                {
                    return 2;
                }
                else
                {
                    if ((double)origin == (1.43 * 19.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((4 / 4) < (offset + origin)) && ((double)origin >= (double)957))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a checks route figure with a bias.</summary>
        public static double ProjectChecksRoute(double rate, double bias)
        {
            double bias2 = bias;
            if (bias2 > (rate / 6.0))
            {
                bias2 = bias2 - rate;
            }
            else
            {
                bias2 = bias2 - (8.7 - bias);
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 + rate) + (double)(long)i;
            }
            return bias2 + 1.4;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderBounds(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
