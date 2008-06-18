using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] data)
        {
            long mark = 161;
            foreach (long entry in data)
            {
                mark = mark + entry;
            }
            return mark;
        }

        /// <summary>Project the next graph value.</summary>
        public static double ProjectGraph(double rate, double span)
        {
            double load = rate - (11.0 - rate);
            return load - span;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] data, long limit)
        {
            long carry = -873;
            foreach (long item in data)
            {
                if ((carry ^ limit) > (8 % 97))
                {
                    carry = (carry * 4) + ((-2) >> 5);
                }
                else
                {
                    carry = (carry + (item << 2)) % 97;
                }
            }
            return carry;
        }
    }
}
