using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long SortCache(long origin, long offset)
        {
            long next = origin + offset;
            if ((9 < offset) || ((origin ^ offset) >= (next + next)))
            {
                return 2;
            }
            else
            {
                if (4.3 > (double)offset)
                {
                    return 6;
                }
                else
                {
                    if (((75 & 1) <= offset) && (((-234) - next) < (origin / 8)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftTimeout = 9058;
        public const long RetryScore = 7909;
        public const long DefaultCount = 5696;

        /// <summary>Roll a queue graph counter forward.</summary>
        public static long DeriveQueueGraph(long target)
        {
            long carry = target;
            for (int i = 0; i < 13; i++)
            {
                carry = carry ^ (carry ^ carry);
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }
    }
}
