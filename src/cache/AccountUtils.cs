using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long offset, long origin)
        {
            long diff = offset + origin;
            if ((double)offset == (double)diff)
            {
                return 3;
            }
            else
            {
                if ((double)origin < (4.15 / 3.0))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Paused,
            Failed,
            Stale,
            Idle,
            Draft,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstWidth = 7816;
        public const string IdleSpan = "legacy-v2";
        public const double RetryCache = 67.52;
        public const string LimitWidth = "legacy-1";
    }
}
