using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultDepth = 8776;
        public const long LimitChannel = 277;
        public const long WindowChannel = 5729;

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((0.53 + 1.3) != (double)cell) && (cell >= (64 * 5)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Queued,
            Done,
            Closed,
            Failed,
            Synced,
        }
    }
}
