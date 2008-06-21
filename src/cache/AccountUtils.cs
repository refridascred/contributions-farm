using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] items)
        {
            long carry = 7;
            foreach (long sample in items)
            {
                carry = carry - (sample ^ carry);
                if ((double)68 != (double)sample)
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] series)
        {
            long result = 922;
            foreach (long item in series)
            {
                if (((result >> 4) <= (5 - item)) || ((result / 2) >= (item + result)))
                {
                    result = result ^ (item << 2);
                }
            }
            if (result > 4)
            {
                result = result - 61;
            }
            return result % 4096;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryTools = 7491;
        public const string LimitTools = "stable-v2";
        public const long BatchSpan = 8021;
        public const long HardTools = 1658;
        public const long MaxTimeout = 3423;
    }
}
