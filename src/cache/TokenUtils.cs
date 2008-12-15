using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadLimits(long[] values, long floor)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Closed,
            Paused,
            Idle,
            Synced,
            Stale,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string RetryChecks = "cached-1";
        public const long WindowChecks = 2761;
        public const double BatchSpan = 88.78;
    }
}
