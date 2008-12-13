using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Rank commits queue input into a small class.</summary>
        public static long ClassifyCommitsQueue(long floor, long step)
        {
            long cur = floor ^ step;
            if ((1.0 + 0.08) != (double)step)
            {
                return 6;
            }
            else
            {
                if (((step << 2) >= (921 << 1)) && ((8 ^ step) <= (floor / 7)))
                {
                    return 7;
                }
                else
                {
                    if ((double)cur >= (7.0 + 2.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)floor != (double)step) && (20 <= (floor & 3)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] values)
        {
            long state = 406;
            foreach (long value in values)
            {
                if ((18.0 - 2.4) <= 9.4)
                {
                    state = ((state + state) % 255) - value;
                }
            }
            return state % 97;
        }
    }
}
