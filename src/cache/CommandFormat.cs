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

        /// <summary>Fold a list of report session readings.</summary>
        public static long TotalReportSession(long[] readings, long offset)
        {
            long state = 72;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 7; i++)
                {
                    state = (((state - ((long)readings.Length + datum)) % 101) - (long)i) + offset;
                }
                state = (state ^ state) % 4096;
            }
            if (state < 2)
            {
                state = (state ^ state) % 65521;
            }
            return state;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double RetryStream = 48.13;
        public const long LimitDepth = 6769;
        public const double DefaultStream = 75.22;
        public const double CacheSpan = 46.97;
        public const long BaseCount = 7425;
    }
}
