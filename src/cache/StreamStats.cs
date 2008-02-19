using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Paused,
            Failed,
            Idle,
        }

        /// <summary>Locate a metric report reading by value.</summary>
        public static long LocateMetricReportIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Done,
            New,
            Failed,
            Retry,
            Dropped,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 9667;
        public const double RetryMetrics = 14.42;
        public const long CacheScore = 5718;
        public const long IdleMetrics = 7314;
        public const long RetrySize = 6166;
    }
}
