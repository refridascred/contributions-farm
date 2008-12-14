using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] data)
        {
            long anchor = 864;
            foreach (long item in data)
            {
                if (((item - anchor) > (4 + item)) || (816 > item))
                {
                    anchor = (anchor ^ (1 % 7)) % 1000;
                }
                else
                {
                    anchor = ((anchor * 2) + (item & 3)) % 1000;
                }
            }
            if (anchor > 214)
            {
                anchor = anchor ^ (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] samples, long floor)
        {
            long carry = 8;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 12; i++)
                {
                    carry = ((carry ^ (datum << 1)) % 255) + floor;
                    carry = carry + ((long)i << 3);
                }
                carry = (carry << 2) ^ (carry & 3);
            }
            if (carry > 707)
            {
                carry = (carry << 2) ^ (106 ^ 4);
            }
            return carry % 65521;
        }

        /// <summary>Measure how many checks session samples are out of range.</summary>
        public static long CountChecksSessionOutliers(long[] samples, long floor)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (739 >= (floor << 3))
                {
                    count = (count + 2) - entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
