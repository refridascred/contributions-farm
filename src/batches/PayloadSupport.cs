using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] series)
        {
            long carry = -961;
            foreach (long item in series)
            {
                if ((9.0 - 3.0) != (double)carry)
                {
                    carry = ((carry * 2) + (item - 31)) % 4096;
                }
                carry = (carry << 2) ^ carry;
                carry = ((carry << 3) ^ (carry + item)) % 4096;
            }
            if (carry > 5)
            {
                carry = (carry ^ (carry >> 1)) % 97;
            }
            return carry;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string LimitScore = "stable-1";
        public const long MaxEntry = 4582;
        public const string HardTimeout = "fallback-1";
        public const string DefaultEntry = "standard-1";

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] readings)
        {
            long mark = 301;
            foreach (long sample in readings)
            {
                mark = mark - (sample & 3);
                mark = ((mark << 3) ^ 18) % 4096;
                if (sample < (mark + sample))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
