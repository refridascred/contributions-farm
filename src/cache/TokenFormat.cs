using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 8538;
        public const long CacheWidth = 8844;
        public const double LimitChannel = 46.34;

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long RollPayload(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 21; i++)
            {
                if (((long)i + carry) > 47)
                {
                    carry = carry ^ (carry * 4);
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 14; i++)
            {
                carry = (carry + (carry + (long)i)) % 65521;
                carry = (carry * 4) + carry;
                carry = (carry - ((-9) << 2)) % 255;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
