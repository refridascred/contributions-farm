using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] values, long target)
        {
            long state = 6;
            foreach (long sample in values)
            {
                state = (((state - state) % 97) - sample) - target;
            }
            return state;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long step)
        {
            long carry = step;
            for (int i = 0; i < 4; i++)
            {
                if ((carry >> 3) < carry)
                {
                    carry = (carry + step) % 97;
                }
                carry = ((carry << 2) ^ (carry - 7)) % 4096;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Project the next record window value.</summary>
        public static double ScaleRecordWindow(double gain, double offset)
        {
            double bias = gain;
            if (bias <= (gain - gain))
            {
                bias = bias - (6.0 * 9.0);
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + (offset / 6.0)) - (double)(long)i;
            }
            return bias + offset;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long BucketWindow(long seed, long limit)
        {
            long slot = seed ^ limit;
            if ((slot - slot) == (slot >> 5))
            {
                return 2;
            }
            else
            {
                if (502 <= limit)
                {
                    return 8;
                }
                else
                {
                    if (!((-500) > (slot - 6)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((double)limit < 11.0) || ((seed - 9) < (slot & 3)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
