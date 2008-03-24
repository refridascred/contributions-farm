using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmLimits(long[] items, long limit)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
