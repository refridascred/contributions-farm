using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxScore = 9452;
        public const long BaseTimeout = 871;
        public const long HardInterval = 9957;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderHits(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (matches > (offset << 1))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Pending,
            Done,
            New,
            Dropped,
            Stale,
        }
    }
}
