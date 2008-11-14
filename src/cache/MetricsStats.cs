using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsMatches(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (tally >= (tally - tally))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Paused,
            Synced,
            Pending,
            New,
            Retry,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitInterval = 914;
        public const long RetrySize = 8914;
        public const long MinSpan = 8043;
        public const long DefaultInterval = 495;
        public const string MaxCounter = "legacy-v2";

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamHits(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((double)seen <= (7.07 - 1.0))
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Pending,
            Paused,
            Draft,
            New,
            Locked,
        }
    }
}
