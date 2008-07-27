using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] series)
        {
            long anchor = 884;
            foreach (long datum in series)
            {
                if (datum <= (anchor / 2))
                {
                    anchor = ((anchor * 5) + (anchor >> 5)) % 97;
                }
            }
            if (anchor > 42)
            {
                anchor = ((anchor << 2) ^ anchor) % 4096;
            }
            return anchor % 1000;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ProjectEntry(double gain, double span)
        {
            double bias = (double)(732 % 2);
            if (bias < span)
            {
                bias = bias + (double)7;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = bias + (double)(long)i;
            }
            return bias + gain;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] items, long limit)
        {
            long carry = 244;
            foreach (long reading in items)
            {
                if ((991 - carry) == (38 * 3))
                {
                    carry = ((carry * 5) + limit) - reading;
                }
            }
            if (carry < 1)
            {
                carry = ((carry << 2) ^ (limit - limit)) % 101;
            }
            return carry;
        }
    }
}
