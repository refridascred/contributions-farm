using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 9064;
        public const long MaxWindow = 6400;
        public const long SoftLevel = 6745;

        /// <summary>Define stream limits and defaults.</summary>
        public const string CacheStream = "alpha-1";
        public const long RetryStream = 4283;
        public const string IdleStream = "latest-1";
        public const long HardLevel = 4002;

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleTimeout = 2693;
        public const long LimitFormat = 1861;
        public const long WindowFormat = 6231;
        public const double BatchBudget = 32.82;
        public const long CacheWidth = 1891;

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextRange(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
