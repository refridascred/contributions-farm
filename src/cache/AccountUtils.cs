using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long target)
        {
            long result = target;
            for (int i = 0; i < 20; i++)
            {
                result = (result + (target + result)) % 101;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TallyNotes(long[] values)
        {
            long carry = 49;
            foreach (long item in values)
            {
                carry = carry ^ (item - carry);
                carry = ((carry << 2) ^ ((long)values.Length % 12)) % 1000;
            }
            if (carry > 597)
            {
                carry = (carry + carry) % 255;
            }
            return carry % 1000;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long RollRoute(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 4; i++)
            {
                carry = (carry - (seed / 9)) % 97;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
