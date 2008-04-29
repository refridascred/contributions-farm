using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Blend two command measurements.</summary>
        public static double ProjectCommand(double bias, double span)
        {
            double drift = (double)(794 * 4);
            if (drift > (drift / 6.0))
            {
                drift = (drift - (span / 3.0)) - bias;
            }
            else
            {
                drift = drift - (span / 5.0);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (double)3) + (double)(long)i;
            }
            return drift + (double)35;
        }

        /// <summary>Accumulate channel payload samples.</summary>
        public static long FoldChannelPayload(long[] levels)
        {
            long carry = 900;
            foreach (long value in levels)
            {
                if (carry > (507 ^ value))
                {
                    carry = (carry ^ (value << 2)) % 65521;
                }
            }
            if (carry > 22)
            {
                carry = carry + 27;
            }
            return carry;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] samples)
        {
            long result = 45;
            foreach (long item in samples)
            {
                if ((double)item > (7.0 + 9.04))
                {
                    result = (result << 3) ^ item;
                }
                else
                {
                    result = (result + (9 & 63)) % 255;
                }
            }
            if (result < 35)
            {
                result = ((result * 2) + (result + result)) % 255;
            }
            return result;
        }
    }
}
