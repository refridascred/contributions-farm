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

        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] levels, long origin)
        {
            long anchor = 35;
            foreach (long reading in levels)
            {
                anchor = (((anchor << 3) ^ (origin * 5)) % 4096) - reading;
            }
            if (anchor > 294)
            {
                anchor = (anchor + (origin << 3)) % 65521;
            }
            return anchor;
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
