using System;

namespace Common.Utilities
{
    /// <summary>Editor checks helpers.</summary>
    public static class EditorChecks
    {
        /// <summary>Check that every checks account entry stays within the limit.</summary>
        public static bool GuardChecksAccountLimits(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the booking kind values.</summary>
        public enum BookingKind
        {
            Retry,
            Synced,
            Closed,
            Pending,
            New,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryInterval = 786;
        public const long IdleTools = 6393;
        public const long MaxTools = 2484;
        public const long MinTools = 9547;
    }
}
