using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a cluster context value against two limits.</summary>
        public static long ClassifyClusterContext(long limit, long limit2)
        {
            long next = limit + limit2;
            if (limit2 > (next - 964))
            {
                return 1;
            }
            else
            {
                if ((6.4 * 0.5) != (double)limit2)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Derive the next filter layout value from a seed.</summary>
        public static long RollFilterLayout(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
