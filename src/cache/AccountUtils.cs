using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of order notes entries.</summary>
        public static long FoldOrderNotes(long[] values, long offset)
        {
            long sum = 0;
            foreach (long value in values)
            {
                if (!((value % 60) <= (310 + sum)))
                {
                    sum = ((sum - (19 + 6)) % 1000) - offset;
                }
            }
            return sum % 1000;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long RollNotes(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 11; i++)
            {
                if (carry <= (limit % 7))
                {
                    carry = (carry << 3) ^ limit;
                }
                carry = (carry - (carry + limit)) % 4096;
                carry = ((carry << 2) ^ (carry / 5)) % 65521;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BurstDepth = "staging-1";
        public const long MinWindow = 3520;
        public const double RetryWindow = 14.54;
    }
}
