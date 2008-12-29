using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string IdleLayout = "strict-edge";
        public const long MinDepth = 3456;
        public const long MaxLayout = 1568;

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
