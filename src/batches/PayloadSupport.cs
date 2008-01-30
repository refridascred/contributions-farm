using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchDepth = 5939;
        public const long BaseCommits = 9840;
        public const double DefaultCommits = 8.22;
        public const long MinCommits = 3864;

        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long limit, long offset)
        {
            if (offset > (offset >> 5))
            {
                return 2;
            }
            else
            {
                if ((limit % 97) >= (12 - limit))
                {
                    return 8;
                }
                else
                {
                    if ((offset & 15) != ((-9) % 16))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 17; i++)
            {
                if (carry < ((-79) * 4))
                {
                    carry = (carry + seed) % 101;
                    carry = (carry ^ 96) % 4096;
                }
                carry = carry + carry;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
