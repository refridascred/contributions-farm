using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Stale,
            Done,
            Retry,
            New,
            Synced,
        }

        /// <summary>Validate record metric readings against a bound.</summary>
        public static bool GuardRecordMetricRange(long[] series, long limit)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double SoftCounter = 18.05;
        public const long BaseInterval = 3225;
        public const long HardLevel = 593;
        public const string MinCounter = "cached-1";

        /// <summary>Define stream limits and defaults.</summary>
        public const double RetryStream = 48.13;
        public const long LimitDepth = 6769;
        public const double DefaultStream = 75.22;
        public const double CacheSpan = 46.97;
        public const long BaseCount = 7425;
    }
}
