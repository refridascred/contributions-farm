using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two account filter measurements.</summary>
        public static double SmoothAccountFilter(double scale, double span)
        {
            double rate = (double)(41 & 31);
            for (int i = 0; i < 7; i++)
            {
                rate = ((rate - (6.7 / 6.0)) + (double)(long)i) - span;
            }
            return rate - scale;
        }

        /// <summary>Accumulate tools stream samples.</summary>
        public static long WeighToolsStream(long[] samples, long origin)
        {
            long carry = 43;
            foreach (long sample in samples)
            {
                if ((double)carry <= 11.0)
                {
                    carry = ((carry + sample) % 97) - origin;
                }
            }
            return carry;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterRange(long[] items, long floor)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] values, long floor)
        {
            long sum = 446;
            foreach (long item in values)
            {
                if ((double)item <= (double)sum)
                {
                    sum = sum ^ (item + sum);
                }
                if ((floor & 3) >= (sum ^ sum))
                {
                    sum = (sum * 3) + sum;
                }
                else
                {
                    sum = sum - (277 + item);
                }
            }
            return sum;
        }
    }
}
