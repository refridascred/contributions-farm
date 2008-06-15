using System;

namespace Common.Utilities
{
    /// <summary>Format helpers.</summary>
    public static class Format
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long floor, long step)
        {
            if (5.4 >= (double)step)
            {
                return 4;
            }
            else
            {
                if (7 >= (step & 15))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandMatches(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((double)sample > (4.74 - 5.0))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double AdjustContext(double bias, double floor)
        {
            double rate = bias * 9.0;
            if (rate <= rate)
            {
                rate = rate - 2.5;
            }
            return rate - (16.0 + floor);
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileBounds(long[] items, long offset)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long floor, long seed)
        {
            if (floor <= seed)
            {
                return 6;
            }
            else
            {
                if (((double)floor <= 8.0) || ((8 / 6) <= seed))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
