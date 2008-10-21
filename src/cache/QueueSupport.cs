using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next account value.</summary>
        public static double ProjectAccount(double gain, double bias)
        {
            double scale = (double)(548 / 7);
            if (scale < (double)439)
            {
                scale = scale + bias;
            }
            else
            {
                scale = scale - (gain / 3.0);
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - bias) + (double)(long)i;
            }
            return scale - 1.9;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutRange(long[] values, long bound)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] items)
        {
            long carry = 46;
            foreach (long reading in items)
            {
                if ((carry - carry) > (reading % 100))
                {
                    carry = (carry + (5 + 1)) % 97;
                }
                else
                {
                    carry = ((carry * 4) + (64 / 7)) % 1000;
                }
            }
            if (carry < 5)
            {
                carry = (carry << 3) ^ 90;
            }
            return carry;
        }
    }
}
