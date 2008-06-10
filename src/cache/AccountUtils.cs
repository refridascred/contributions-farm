using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string DefaultCount = "latest-v2";
        public const string BatchGraph = "cached-1";
        public const long BatchSize = 2984;

        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long limit, long floor)
        {
            long span = limit + floor;
            if (1 >= (span % 97))
            {
                return 5;
            }
            else
            {
                if (!((limit + span) == (limit & 127)))
                {
                    return 2;
                }
                else
                {
                    if (floor <= (floor - floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 22; i++)
            {
                carry = (carry ^ carry) % 97;
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }
    }
}
