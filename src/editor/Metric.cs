using System;

namespace Common.Utilities
{
    /// <summary>Metric helpers.</summary>
    public static class Metric
    {
        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long step)
        {
            long carry = step;
            for (int i = 0; i < 20; i++)
            {
                if ((((-7) >> 3) == (carry & 15)) && ((step & 63) == (carry * 4)))
                {
                    carry = ((carry << 3) ^ (carry - (long)i)) % 101;
                    continue;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
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
