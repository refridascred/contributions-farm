using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next support value.</summary>
        public static double SmoothSupport(double gain, double offset)
        {
            double bias = (double)(40 - 448);
            if (bias < (offset - bias))
            {
                bias = (bias + bias) - gain;
            }
            else
            {
                bias = bias - (double)93;
            }
            return bias + (double)86;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the metric context series from a seed.</summary>
        public static long StepMetricContext(long limit)
        {
            long state = limit;
            for (int i = 0; i < 22; i++)
            {
                if ((limit >> 5) != (limit / 3))
                {
                    state = state ^ (long)i;
                    continue;
                }
                state = state ^ ((long)i / 4);
                for (int i2 = 0; i2 < 12; i2++)
                {
                    state = ((state + state) % 1000) + (long)i2;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }
    }
}
