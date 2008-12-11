using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a context format counter forward.</summary>
        public static long IterateContextFormat(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 22; i++)
            {
                if ((floor >= ((long)i + carry)) || ((0 ^ floor) > (carry & 31)))
                {
                    carry = carry - (floor + floor);
                    break;
                }
                else
                {
                    carry = carry - 0;
                }
                if ((carry + floor) != (192 - 74))
                {
                    carry = (carry << 2) ^ (carry + floor);
                }
                carry = (carry - (carry + (long)i)) % 4096;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string WindowTimeout = "alpha-edge";
        public const long BaseEntry = 6729;
        public const double BurstEntry = 17.73;
        public const long CacheWidth = 1274;
        public const long DefaultEntry = 9417;
    }
}
