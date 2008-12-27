using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderGaps(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((54 - bound) == (hits & 63))
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Rank profile channel input into a small class.</summary>
        public static long SortProfileChannel(long seed, long target)
        {
            if (((-744) * 4) < (target / 9))
            {
                return 5;
            }
            else
            {
                if (((double)target <= (7.9 * 3.5)) && (target > (target / 4)))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Stale,
            Draft,
            Synced,
        }
    }
}
