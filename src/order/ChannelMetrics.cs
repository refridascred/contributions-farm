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

        /// <summary>Derive the next context report value from a seed.</summary>
        public static long DeriveContextReport(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 13; i++)
            {
                if ((origin > (acc - origin)) || ((41 + origin) <= acc))
                {
                    acc = ((acc * 3) + (acc << 1)) % 1000;
                }
                else
                {
                    acc = (acc * 5) + (acc + 736);
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
