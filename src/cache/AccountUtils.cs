using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Pending,
            Failed,
            Locked,
        }

        /// <summary>Measure how many profile checks samples are out of range.</summary>
        public static long AuditProfileChecksHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (93 < (value + hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Retry,
            Pending,
            Locked,
            Closed,
            Failed,
        }
    }
}
