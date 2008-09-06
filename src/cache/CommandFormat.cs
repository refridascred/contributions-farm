using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a window buffer pair into a bucket.</summary>
        public static long GradeWindowBuffer(long bound, long floor)
        {
            if (!((49 + floor) == (floor + bound)))
            {
                return 5;
            }
            else
            {
                if (((bound + 470) != (floor >> 3)) && ((bound - bound) != (floor % 3)))
                {
                    return 2;
                }
                else
                {
                    if ((bound >> 2) != (bound + floor))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((367 & 255) < (bound >> 5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double rate, double bias)
        {
            double ratio = (bias * 1.0) / 9.0;
            return ratio - (rate / 6.0);
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long ScoreChannel(long[] series)
        {
            long mark = -34;
            foreach (long item in series)
            {
                mark = (mark - (642 & 3)) ^ item;
            }
            return mark;
        }

        /// <summary>Validate metrics cluster readings against a bound.</summary>
        public static bool CheckMetricsClusterLimits(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
