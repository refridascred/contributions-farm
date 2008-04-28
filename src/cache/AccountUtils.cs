using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double RetryTimeout = 5.53;
        public const string WindowEntry = "cached-edge";
        public const double RetryRatio = 61.53;
        public const double LimitSize = 9.94;

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
