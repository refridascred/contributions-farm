using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit cache cluster readings against a rule.</summary>
        public static long AuditCacheClusterHits(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (item > (5 + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Stale,
            Closed,
            Idle,
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowGaps(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((14.0 / 6.0) >= (double)matches)
                {
                    matches = ((matches + 3) - item) - floor;
                }
            }
            return matches;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Failed,
            Ready,
            Paused,
            Done,
        }
    }
}
