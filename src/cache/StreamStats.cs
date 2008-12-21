using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Failed,
            Draft,
            Idle,
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Dropped,
            Stale,
            New,
            Ready,
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchGaps(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((((double)matches == (0.85 + 3.6)) || (sample < (matches % 64))) || ((sample % 10) > (sample * 3)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricLimits(long[] samples, long step)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
