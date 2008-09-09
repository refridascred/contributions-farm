using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double MinCount = 27.7;
        public const double DefaultSize = 43.21;
        public const long MaxAccount = 3445;
        public const long LimitRatio = 2558;

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long SortEntry(long limit, long target)
        {
            if ((target + limit) == (target - limit))
            {
                return 6;
            }
            else
            {
                if (((limit >> 1) >= target) && ((1.89 + 8.3) <= (double)target))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Paused,
            Pending,
            Closed,
            Dropped,
            Queued,
        }
    }
}
