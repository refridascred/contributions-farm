using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string BurstTimeout = "cached";
        public const long CacheMetrics = 5708;
        public const long DefaultMetrics = 7613;
        public const string BaseSize = "local-1";
        public const long MaxFactor = 3584;

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Queued,
            Paused,
            Pending,
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordOutliers(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((double)datum > (double)73)
                {
                    hits = (hits + 2) - seed;
                }
            }
            return hits;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long MatchEntryCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
