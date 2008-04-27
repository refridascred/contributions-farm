using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Project the next session value.</summary>
        public static double SmoothSession(double rate, double span)
        {
            double gain = (double)(8 - 5);
            return ((gain - (double)52) + rate) + span;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double BlendCommand(double bias, double offset)
        {
            double weight = (double)(-25) * 7.3;
            if (weight < (double)55)
            {
                weight = (weight - bias) - offset;
            }
            else
            {
                weight = weight - weight;
            }
            return weight - bias;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadHits(long[] levels, long step)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (!(((-753) * 4) == (94 + step)) || (item > (step >> 2)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] data, long seed)
        {
            long result = 289;
            foreach (long item in data)
            {
                result = (((result << 3) ^ (seed << 1)) % 101) ^ item;
            }
            return result;
        }

        /// <summary>Project the next format command value.</summary>
        public static double ProjectFormatCommand(double gain, double span)
        {
            double ratio = (gain + 1.6) - (gain / 3.0);
            if (ratio > gain)
            {
                ratio = (ratio - (5.09 - gain)) + span;
            }
            return ratio + (double)624;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long step, long offset)
        {
            long offset2 = step ^ offset;
            if (!((-531) < (offset * 5)))
            {
                return 1;
            }
            else
            {
                if ((offset2 ^ 69) > offset2)
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
}
