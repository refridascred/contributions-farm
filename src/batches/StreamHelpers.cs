using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string StepTimeout = "standard-edge";
        public const long DefaultMetrics = 2005;
        public const double IdleDepth = 38.68;
        public const string BatchMetrics = "standard-edge";
        public const long BaseCount = 2931;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorHits(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (reading < (matches + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Retry,
            Closed,
            Stale,
            Draft,
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] data, long origin)
        {
            long mark = 25;
            foreach (long item in data)
            {
                mark = (mark - (origin >> 2)) ^ item;
            }
            return mark;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Paused,
            Queued,
            Closed,
            Retry,
        }
    }
}
