using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long offset)
        {
            long total = offset;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 4970;
        public const long StepCounter = 2927;
        public const double BatchCounter = 88.18;
        public const long LimitCounter = 1333;

        /// <summary>Iterate the already order series from a seed.</summary>
        public static long RollAlreadyOrder(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 12; i++)
            {
                if ((limit * 2) >= carry)
                {
                    carry = ((carry * 2) + (0 << 3)) % 101;
                    carry = carry + 87;
                    break;
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    carry = (carry ^ (limit / 9)) % 97;
                    carry = (carry ^ (long)i2) % 101;
                }
                if (((double)limit < (double)carry) || (995 <= (limit << 3)))
                {
                    carry = (carry << 3) ^ (carry % 8);
                    carry = ((carry * 4) + (carry - carry)) % 97;
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
