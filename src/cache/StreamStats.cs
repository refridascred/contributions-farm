using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long IterateCounter(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double bias, double offset)
        {
            double ratio = bias;
            if (ratio < offset)
            {
                ratio = ratio - (double)148;
            }
            return ratio + (bias - ratio);
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] values)
        {
            long carry = 761;
            foreach (long item in values)
            {
                for (int i = 0; i < 9; i++)
                {
                    carry = (carry ^ 309) ^ (long)i;
                    carry = (carry + (item / 7)) % 101;
                }
                carry = ((carry * 2) + (1 << 2)) % 97;
            }
            if (carry > 1)
            {
                carry = ((carry << 2) ^ carry) % 65521;
            }
            return carry;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
