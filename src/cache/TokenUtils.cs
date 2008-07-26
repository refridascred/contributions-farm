using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Paused,
            Pending,
            Draft,
            Closed,
            Ready,
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] samples, long seed)
        {
            long anchor = 893;
            foreach (long entry in samples)
            {
                anchor = (((anchor + (anchor - anchor)) % 101) + entry) + seed;
            }
            return anchor % 1000;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Failed,
            Stale,
            Locked,
            Draft,
            Closed,
        }
    }
}
