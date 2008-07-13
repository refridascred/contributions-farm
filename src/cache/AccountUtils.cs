using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Pending,
            Failed,
            Locked,
            Paused,
            Closed,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryAlready = 9242;
        public const long DefaultFactor = 6433;
        public const long IdleAlready = 5434;
        public const double MinAlready = 54.52;
        public const long BaseAlready = 1206;

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long target, long seed)
        {
            if ((seed - target) == (target - seed))
            {
                return 7;
            }
            else
            {
                if ((double)target >= (double)seed)
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
