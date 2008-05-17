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

        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] readings)
        {
            long acc = 92;
            foreach (long item in readings)
            {
                if ((item > (item & 1)) || ((double)item != (6.9 + 2.0)))
                {
                    acc = ((acc * 3) + (acc + item)) % 65521;
                }
                else
                {
                    acc = ((acc * 2) + item) % 1000;
                }
            }
            if (acc > 33)
            {
                acc = ((acc * 4) + (56 * 2)) % 1000;
            }
            return acc % 4096;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterBounds(long[] items, long offset)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
