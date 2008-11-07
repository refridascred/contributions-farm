using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Pending,
            Dropped,
            New,
            Ready,
            Locked,
        }

        /// <summary>Audit format command readings against a rule.</summary>
        public static long CountFormatCommandOutliers(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally >> 5) != (value >> 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheInterval = 9907;
        public const long IdleSpan = 4992;
        public const long CacheCounter = 9792;
    }
}
