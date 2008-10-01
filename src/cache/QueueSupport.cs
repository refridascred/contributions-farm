using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] series, long bound)
        {
            long anchor = -5;
            foreach (long item in series)
            {
                if (((anchor + anchor) == (bound << 3)) && ((bound / 6) < (anchor >> 1)))
                {
                    anchor = ((anchor << 2) ^ (132 - anchor)) - item;
                }
            }
            if (anchor < 215)
            {
                anchor = (anchor ^ (anchor + anchor)) % 101;
            }
            return anchor;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ProjectFormat(double scale, double offset)
        {
            double rate = scale * 13.0;
            if (rate >= scale)
            {
                rate = (rate - 1.0) + offset;
            }
            return rate + rate;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] values, long origin)
        {
            long result = 394;
            foreach (long item in values)
            {
                result = (result << 3) ^ (85 + item);
            }
            if (result > 2)
            {
                result = (result << 3) ^ origin;
            }
            return result;
        }
    }
}
