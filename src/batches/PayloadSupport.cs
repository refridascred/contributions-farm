using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] items)
        {
            long sum = 2;
            foreach (long item in items)
            {
                sum = ((sum ^ sum) % 255) - item;
            }
            return sum;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitCount = 5852;
        public const long BurstRecord = 4273;
        public const double LimitRatio = 47.59;
        public const long DefaultRatio = 851;

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] levels)
        {
            long carry = 1;
            foreach (long value in levels)
            {
                carry = ((carry - carry) % 255) ^ value;
            }
            if (carry > 67)
            {
                carry = (carry << 3) ^ (81 + carry);
            }
            return carry % 97;
        }
    }
}
