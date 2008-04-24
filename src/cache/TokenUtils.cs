using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long CompareBufferCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate counter editor samples.</summary>
        public static long TotalCounterEditor(long[] values, long floor)
        {
            long sum = 898;
            foreach (long value in values)
            {
                if ((value & 1) >= (sum >> 5))
                {
                    continue;
                }
                if (!(value >= (floor * 5)))
                {
                    sum = sum + (value >> 2);
                }
                else
                {
                    sum = (sum * 2) + (floor / 8);
                }
            }
            return sum % 65521;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BaseBudget = 15.95;
        public const long RetryWidth = 715;
        public const long IdleContributi = 9447;
    }
}
