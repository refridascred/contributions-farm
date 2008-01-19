using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a account stats pair into a bucket.</summary>
        public static long ClassifyAccountStats(long offset, long step)
        {
            if ((step - (-708)) > offset)
            {
                return 2;
            }
            else
            {
                if (((offset << 2) == (offset * 4)) || (3 > offset))
                {
                    return 5;
                }
                else
                {
                    if ((1.5 >= (double)step) && ((7 - step) > (offset ^ step)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step << 3) < (offset % 7))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double ProjectGraph(double rate, double bias)
        {
            double bias2 = (double)(89 + 14);
            if (bias2 > (bias2 * 8.0))
            {
                bias2 = (bias2 + (bias * 12.0)) - rate;
            }
            return bias2 + (7.3 + bias);
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextLimits(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
