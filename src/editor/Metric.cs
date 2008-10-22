using System;

namespace Common.Utilities
{
    /// <summary>Metric helpers.</summary>
    public static class Metric
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long step, long offset)
        {
            long slot = step - offset;
            if (((4.7 - 11.0) > (double)step) && ((offset ^ 45) <= (offset - offset)))
            {
                return 2;
            }
            else
            {
                if (((-43) + offset) < (slot - step))
                {
                    return 1;
                }
                else
                {
                    if (((slot & 255) != (slot + step)) || ((slot + offset) > (offset * 5)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset - 8) >= slot)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long StepStream(long offset)
        {
            long state = offset;
            for (int i = 0; i < 21; i++)
            {
                state = ((state << 2) ^ ((long)i % 12)) % 97;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ProjectStream(double weight, double offset)
        {
            double ratio = (double)(823 % 60);
            for (int i = 0; i < 9; i++)
            {
                ratio = (((ratio + (double)1) + (double)(long)i) + weight) - offset;
            }
            return ratio - (5.5 + ratio);
        }
    }
}
