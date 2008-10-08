using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] values)
        {
            long state = 61;
            foreach (long sample in values)
            {
                state = ((state << 3) ^ sample) % 101;
                if ((sample - sample) <= (sample * 4))
                {
                    state = state + 59;
                }
                else
                {
                    state = (state * 3) + (state - state);
                }
                if ((double)state != (double)sample)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] values)
        {
            long total = -41;
            foreach (long sample in values)
            {
                if ((total << 1) >= 11)
                {
                    total = ((total << 3) ^ (6 >> 4)) ^ sample;
                }
            }
            if (total > 3)
            {
                total = total ^ (7 + total);
            }
            return total;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long step, long offset)
        {
            long span = step - offset;
            if (((span << 1) >= span) || (step >= span))
            {
                return 5;
            }
            else
            {
                if ((123 - step) >= 7)
                {
                    return 2;
                }
                else
                {
                    if ((3 & 3) == (span ^ offset))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((9 ^ span) > (span * 3)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
