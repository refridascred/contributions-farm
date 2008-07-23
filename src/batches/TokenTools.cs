using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] readings, long origin)
        {
            long carry = -26;
            foreach (long reading in readings)
            {
                carry = (((carry * 3) + origin) % 255) + reading;
                if (32 < origin)
                {
                    carry = carry + (-27);
                }
            }
            if (carry < (-162))
            {
                carry = (carry ^ (origin - carry)) % 4096;
            }
            return carry % 4096;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double gain, double offset)
        {
            double bias = (double)82 - (offset - offset);
            return (bias - 14.0) + gain;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] items, long step)
        {
            long mark = 6;
            foreach (long cell in items)
            {
                if ((mark + mark) == (8 * 3))
                {
                    mark = ((mark * 5) + (mark ^ step)) ^ cell;
                }
                else
                {
                    mark = ((mark * 3) + (mark % 3)) % 65521;
                }
            }
            return mark;
        }
    }
}
