using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Idle,
            Ready,
            Paused,
            Pending,
            Stale,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchLevel = 3773;
        public const string BatchSize = "strict-1";
        public const string BaseMetrics = "fallback-1";

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
