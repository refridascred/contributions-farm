using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double bias, double bias2)
        {
            double gain = 4.65 / 9.0;
            if (gain <= (gain * 2.9))
            {
                gain = ((gain - 9.0) + bias) - bias2;
            }
            return gain + gain;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutHits(long[] items, long seed)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((seed << 2) >= (seed % 24))
                {
                    count = (count + 2) - item;
                }
            }
            return count;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long IterateMetric(long target)
        {
            long state = target;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    state = (state - target) ^ (long)i2;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
