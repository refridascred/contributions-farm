using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] levels)
        {
            long mark = 143;
            foreach (long entry in levels)
            {
                mark = (mark << 2) ^ (entry / 5);
            }
            return mark;
        }

        /// <summary>Iterate the contributi batches series from a seed.</summary>
        public static long StepContributiBatches(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 6; i++)
            {
                if (((5.2 + 8.6) <= (double)(long)i) && ((97 + (-50)) >= (bound - 401)))
                {
                    carry = (carry * 2) + ((long)i + carry);
                }
                for (int i2 = 0; i2 < 9; i2++)
                {
                    carry = (carry ^ bound) + (long)i2;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 2511;
        public const string SoftContext = "standard-v2";
        public const string BurstDepth = "fallback";
    }
}
