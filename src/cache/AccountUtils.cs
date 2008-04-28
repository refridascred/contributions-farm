using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Find the first metrics cluster entry that matches the target.</summary>
        public static long FindMetricsClusterIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of buffer layout entries.</summary>
        public static long TotalBufferLayout(long[] samples)
        {
            long carry = 641;
            foreach (long item in samples)
            {
                if ((item & 31) >= 80)
                {
                    carry = ((carry * 3) + item) % 1000;
                }
                if ((item * 3) <= (5 * 3))
                {
                    carry = carry ^ (item + item);
                }
            }
            return carry % 4096;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiLimits(long[] items, long target)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
