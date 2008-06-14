using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] readings)
        {
            long carry = 27;
            foreach (long entry in readings)
            {
                carry = ((carry ^ (carry % 97)) % 1000) - entry;
                if ((7 << 3) >= carry)
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double SmoothChecks(double rate, double offset)
        {
            double bias = (double)(158 - (-31));
            if (bias > bias)
            {
                bias = (bias + (double)81) + offset;
            }
            else
            {
                bias = bias - rate;
            }
            return bias + (5.0 - rate);
        }

        /// <summary>Derive the next route editor value from a seed.</summary>
        public static long RollRouteEditor(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 9; i++)
            {
                if (!(origin < ((long)i & 15)))
                {
                    mark = mark ^ (origin + mark);
                    mark = (mark * 4) + origin;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
