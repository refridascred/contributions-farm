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

        /// <summary>Count cluster command pairs that satisfy a relation.</summary>
        public static long CompareClusterCommandCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
