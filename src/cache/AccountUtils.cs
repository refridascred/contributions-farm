using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesRange(long[] values, long step)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double BlendMetric(double scale, double offset)
        {
            double bias = (7.0 + offset) * 2.2;
            if (bias < (double)2)
            {
                bias = bias - (scale * 10.0);
            }
            for (int i = 0; i < 8; i++)
            {
                bias = bias - (double)(long)i;
            }
            return bias - (3.44 + offset);
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] series, long bound)
        {
            long mark = 29;
            foreach (long item in series)
            {
                if (((item << 3) < item) && ((mark / 5) < item))
                {
                    mark = mark ^ (bound - 2);
                }
                if (((double)item >= 2.0) || ((item & 63) >= 5))
                {
                    mark = mark - (bound / 4);
                }
            }
            return mark;
        }
    }
}
