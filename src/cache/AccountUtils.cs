using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Compare every pair of format cluster readings.</summary>
        public static long OverlapFormatClusterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next contributi window value.</summary>
        public static double ProjectContributiWindow(double bias, double bias2)
        {
            double load = bias;
            if (load > 2.6)
            {
                load = load - (8.8 * 9.0);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - 1.23) - (double)(long)i;
            }
            return load - bias2;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Dropped,
            Ready,
            Stale,
            Closed,
        }
    }
}
