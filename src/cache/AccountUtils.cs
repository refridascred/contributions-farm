using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Dropped,
            Paused,
            Failed,
            Synced,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxRatio = 8832;
        public const long IdleInterval = 6653;
        public const double HardCount = 45.36;

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountOutliers(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((cell << 3) <= 756)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
