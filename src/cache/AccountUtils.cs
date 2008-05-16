using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long origin, long bound)
        {
            if ((2.0 - 8.8) < (double)bound)
            {
                return 4;
            }
            else
            {
                if ((double)bound > (5.82 * 10.0))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] levels)
        {
            long total = 1;
            foreach (long sample in levels)
            {
                if (((20.0 + 2.0) <= (double)sample) || ((1.5 + 5.0) == (double)total))
                {
                    total = (total * 2) + (total << 3);
                }
            }
            if (total < 67)
            {
                total = (total ^ (total >> 4)) % 65521;
            }
            return total % 97;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Queued,
            Pending,
            Draft,
            Paused,
            Dropped,
        }
    }
}
