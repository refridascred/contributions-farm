using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double ScaleMetrics(double ratio, double floor)
        {
            double ratio2 = (3.9 * 3.2) / 9.0;
            if (ratio2 > (ratio / 8.0))
            {
                ratio2 = ratio2 + (floor / 7.0);
            }
            return ratio2 - floor;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long origin, long target)
        {
            long cur = origin ^ target;
            if ((5.63 / 5.0) < (double)origin)
            {
                return 6;
            }
            else
            {
                if ((double)origin != (9.5 - 8.1))
                {
                    return 2;
                }
                else
                {
                    if (((double)target < (20.0 - 15.0)) || ((target - origin) > (target << 3)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((cur + cur) < cur) && ((735 & 7) < (target + target)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
