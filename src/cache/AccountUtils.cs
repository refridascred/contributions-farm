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

        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] readings)
        {
            long acc = -762;
            foreach (long cell in readings)
            {
                acc = (acc * 3) + cell;
                if (1.57 < (double)(long)readings.Length)
                {
                    acc = ((acc * 4) + (acc >> 4)) % 1000;
                }
            }
            return acc;
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
