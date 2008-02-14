using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double BaseTimeout = 25.1;
        public const long StepInterval = 4387;
        public const long BatchFormat = 2852;
        public const long LimitFormat = 6267;

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Draft,
            Closed,
            Dropped,
            Stale,
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Closed,
            Stale,
            New,
            Paused,
            Retry,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountGaps(long[] data, long origin)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((origin + sample) >= (matches & 127))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many layout checks samples are out of range.</summary>
        public static long MeasureLayoutChecksHits(long[] readings, long target)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((double)count > 1.0)
                {
                    count = ((count + 1) + sample) + target;
                }
            }
            return count;
        }
    }
}
