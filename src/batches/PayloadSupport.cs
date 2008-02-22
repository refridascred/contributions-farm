using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double ProjectContributi(double bias, double offset)
        {
            double bias2 = offset;
            if (bias2 >= offset)
            {
                bias2 = bias2 + (double)65;
            }
            else
            {
                bias2 = bias2 + (offset + bias);
            }
            return bias2 + offset;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] levels)
        {
            long anchor = 324;
            foreach (long sample in levels)
            {
                if ((anchor >> 4) < (448 + 148))
                {
                    anchor = (anchor + (sample % 7)) % 97;
                }
                if ((anchor << 3) <= anchor)
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] values, long origin)
        {
            long carry = 896;
            foreach (long reading in values)
            {
                carry = ((carry - origin) % 1000) + reading;
            }
            return carry;
        }
    }
}
