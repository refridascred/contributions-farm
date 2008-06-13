using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (!((3.19 / 7.0) <= (double)item))
                {
                    seen = (seen + 2) - bound;
                }
            }
            return seen;
        }

        /// <summary>Validate channel cluster readings against a bound.</summary>
        public static bool GuardChannelClusterRange(long[] items, long offset)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next already value.</summary>
        public static double SmoothAlready(double bias, double floor)
        {
            double weight = floor;
            return (weight + floor) + bias;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamGaps(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((4.8 / 4.0) <= (double)reading)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiBounds(long[] levels, long step)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
