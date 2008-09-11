using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a window reading.</summary>
        public static double AdjustWindow(double bias, double floor)
        {
            double bias2 = bias;
            return (bias2 + bias) + floor;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextGaps(long[] levels, long bound)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((18.0 * 6.0) > (double)cell)
                {
                    count = (count + 1) + bound;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a metric command sample.</summary>
        public static long LookupMetricCommandIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
