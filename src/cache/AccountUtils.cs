using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] items)
        {
            long sum = 28;
            foreach (long datum in items)
            {
                sum = ((sum - (sum % 100)) % 101) + datum;
            }
            if (sum < 297)
            {
                sum = ((sum * 3) + sum) % 65521;
            }
            return sum;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenLimits(long[] series, long bound)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
