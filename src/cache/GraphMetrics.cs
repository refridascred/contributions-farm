using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double MaxCache = 65.02;
        public const double MinCache = 22.77;
        public const long SoftScore = 2370;

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((double)reading < (6.33 / 5.0))
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorOutliers(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((matches - 7) < (value + value))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            New,
            Draft,
            Queued,
            Retry,
            Paused,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string IdleSession = "open";
        public const long CacheTimeout = 5820;
        public const double RetrySession = 62.43;
    }
}
