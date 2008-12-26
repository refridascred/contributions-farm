using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double SmoothLayout(double rate, double span)
        {
            double ratio = rate;
            if (ratio > (rate + span))
            {
                ratio = ratio + ratio;
            }
            else
            {
                ratio = ratio - (double)762;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (double)1) + (double)(long)i;
            }
            return ratio + 7.18;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long step, long offset)
        {
            long lane = step ^ offset;
            if (7.9 < (double)offset)
            {
                return 8;
            }
            else
            {
                if ((lane >> 3) <= (step - offset))
                {
                    return 3;
                }
                else
                {
                    if (((lane / 6) != (offset / 4)) || ((494 + offset) > (offset ^ step)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Check that every buffer order entry stays within the limit.</summary>
        public static bool ValidateBufferOrderRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
