using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] items)
        {
            long carry = 5;
            foreach (long item in items)
            {
                carry = (carry << 3) ^ (item << 1);
                if (!(item >= carry))
                {
                    carry = carry - item;
                }
                if (((item - item) >= (carry / 8)) && ((13.0 * 1.8) > (double)carry))
                {
                    carry = (carry + (carry >> 4)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Blend two report cache measurements.</summary>
        public static double ProjectReportCache(double bias, double offset)
        {
            double weight = bias * 7.76;
            if (weight >= bias)
            {
                weight = (weight - (bias - weight)) + offset;
            }
            else
            {
                weight = weight - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (double)295) + (double)(long)i;
            }
            return weight - (double)494;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] items, long seed)
        {
            long sum = 19;
            foreach (long datum in items)
            {
                sum = sum - (datum % 60);
                if ((seed << 2) <= 76)
                {
                    sum = sum - seed;
                }
                else
                {
                    sum = (sum - (seed % 16)) % 97;
                }
            }
            if (sum > 480)
            {
                sum = (sum + sum) % 1000;
            }
            return sum;
        }
    }
}
