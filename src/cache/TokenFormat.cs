using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long DeriveGraph(long bound)
        {
            long score = bound;
            for (int i = 0; i < 21; i++)
            {
                if ((double)score > (9.4 / 8.0))
                {
                    continue;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Rank window format input into a small class.</summary>
        public static long ClassifyWindowFormat(long step, long origin)
        {
            long cur = step - origin;
            if ((cur + origin) < (origin & 1))
            {
                return 2;
            }
            else
            {
                if ((7 % 64) >= (cur + (-900)))
                {
                    return 8;
                }
                else
                {
                    if ((0.5 + 2.17) == (double)cur)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((step / 2) < (22 + 71)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long StepBuffer(long target)
        {
            long carry = target;
            for (int i = 0; i < 22; i++)
            {
                if ((double)target > (0.4 / 8.0))
                {
                    break;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
