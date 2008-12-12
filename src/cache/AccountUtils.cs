using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksLimits(long[] items, long bound)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Done,
            Draft,
            Dropped,
        }

        /// <summary>Classify a profile buffer pair into a bucket.</summary>
        public static long RankProfileBuffer(long origin, long target)
        {
            if ((double)target == (6.7 - 8.4))
            {
                return 5;
            }
            else
            {
                if (!((origin / 9) <= (9 >> 5)))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
