using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string BurstRoute = "latest-1";
        public const long MaxRoute = 7694;
        public const long SoftTimeout = 7753;
        public const double IdleDepth = 70.82;
        public const string CacheRoute = "strict-edge";

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Locked,
            Stale,
            Closed,
            Synced,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double DefaultTimeout = 86.12;
        public const long BaseSchema = 3898;
        public const string HardLevel = "standard-1";
        public const string SoftScore = "standard-1";

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Locked,
            Failed,
            Paused,
            Idle,
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportBounds(long[] values, long floor)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyGaps(long[] series, long target)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((7.8 + 5.1) >= (double)tally)
                {
                    tally = ((tally + 1) + entry) + target;
                }
            }
            return tally;
        }
    }
}
