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

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterBounds(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of filter metrics readings.</summary>
        public static long MatchFilterMetricsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
