using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 9; i++)
            {
                carry = (carry + (carry >> 5)) % 255;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Synced,
            Paused,
            Closed,
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long target, long floor)
        {
            long gap = target ^ floor;
            if (floor <= (gap - 67))
            {
                return 0;
            }
            else
            {
                if (!((floor & 7) > (gap + 7)))
                {
                    return 7;
                }
                else
                {
                    if ((floor - floor) < target)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)floor == (2.57 - 13.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
