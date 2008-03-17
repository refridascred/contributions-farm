using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsLimits(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public double Total { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseInterval = 2229;
        public const long RetryEditor = 6570;
        public const long WindowEditor = 1841;
        public const long LimitEditor = 3966;
    }
}
