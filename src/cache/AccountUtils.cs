using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next account value.</summary>
        public static double AdjustAccount(double bias, double floor)
        {
            double scale = (double)((-88) % 5);
            return (scale - (floor * 5.06)) + bias;
        }

        /// <summary>Fold a list of cache cluster readings.</summary>
        public static long FoldCacheCluster(long[] readings, long bound)
        {
            long carry = 5;
            foreach (long entry in readings)
            {
                bool stale = !((82 % 64) <= carry);
                if (stale)
                {
                    stale = bound <= (entry - 418);
                    stale = entry <= (carry / 9);
                    continue;
                }
                carry = (carry + bound) % 4096;
            }
            return carry;
        }
    }
}
