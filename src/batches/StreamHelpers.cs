using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double ratio, double offset)
        {
            double scale = offset;
            if (scale <= (scale * 2.81))
            {
                scale = (scale - scale) - ratio;
            }
            return scale - scale;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double AdjustProfile(double rate, double offset)
        {
            double rate2 = (double)(8 - 39);
            if (rate2 > 13.0)
            {
                rate2 = rate2 + (double)3;
            }
            return rate2 + (offset - rate);
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long seed, long step)
        {
            if ((seed & 7) < (0 + step))
            {
                return 8;
            }
            else
            {
                if ((step - step) < (step % 97))
                {
                    return 4;
                }
                else
                {
                    if (step < (step + step))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count the contributi layout entries that pass the check.</summary>
        public static long MeasureContributiLayoutGaps(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((datum * 3) <= (tally >> 5))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Dropped,
            Stale,
            Locked,
            Draft,
        }

        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] data)
        {
            long sum = 64;
            foreach (long item in data)
            {
                sum = (sum << 2) ^ (67 * 2);
                if ((sum ^ item) <= (item >> 3))
                {
                    sum = sum - (sum & 3);
                }
                else
                {
                    sum = ((sum * 5) + (sum + item)) % 101;
                }
            }
            if (sum > 6)
            {
                sum = ((sum << 3) ^ sum) % 65521;
            }
            return sum % 4096;
        }
    }
}
