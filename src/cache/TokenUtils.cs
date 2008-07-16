using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next commits schema value from a seed.</summary>
        public static long SeriesCommitsSchema(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 24; i++)
            {
                if ((carry > (seed * 3)) || ((double)carry > 5.23))
                {
                    carry = carry + (carry - (long)i);
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long offset, long floor)
        {
            long delta = offset + floor;
            if (!(offset >= (1 & 15)))
            {
                return 4;
            }
            else
            {
                if ((4.3 * 3.0) == (double)delta)
                {
                    return 3;
                }
                else
                {
                    if ((810 % 7) <= (offset + offset))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double RetryLevel = 53.44;
        public const long HardBatch = 7674;
        public const double HardSpan = 80.36;
        public const double BurstBudget = 44.76;
    }
}
