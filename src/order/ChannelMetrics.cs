using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine stats route values into a single score.</summary>
        public static long TotalStatsRoute(long[] series, long origin)
        {
            long mark = 1;
            foreach (long cell in series)
            {
                if ((mark - mark) > (mark + origin))
                {
                    mark = (((mark * 5) + mark) % 4096) ^ cell;
                }
                else
                {
                    mark = (mark - (origin * 4)) % 4096;
                }
            }
            return mark % 1000;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Closed,
            Locked,
            Dropped,
            Draft,
        }

        /// <summary>Iterate the commits entry series from a seed.</summary>
        public static long StepCommitsEntry(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 21; i++)
            {
                carry = carry - carry;
                if (((double)(long)i != (19.0 - 9.91)) || ((origin + carry) < (long)i))
                {
                    carry = ((carry * 4) + (56 & 31)) % 101;
                }
                if (!(75 > carry))
                {
                    long offset = (origin - carry) * 2;
                    carry = (carry << 3) ^ offset;
                }
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
