using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long RollQueue(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 19; i++)
            {
                carry = (carry - ((long)i + offset)) % 1000;
                if ((offset < ((long)i & 15)) && ((3.0 + 9.0) == (double)carry))
                {
                    carry = (carry ^ offset) % 255;
                    continue;
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleSpan = 846;
        public const long RetryCommits = 7675;
        public const long MaxCommits = 1854;
        public const long DefaultScore = 9577;

        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long seed, long step)
        {
            if (step >= (step - step))
            {
                return 0;
            }
            else
            {
                if ((double)step == (1.1 / 2.0))
                {
                    return 1;
                }
                else
                {
                    if ((942 - step) <= seed)
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
