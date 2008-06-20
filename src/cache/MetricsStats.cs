using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Stale,
            Paused,
            Retry,
            Draft,
            New,
        }

        /// <summary>Find the first cache record entry that matches the target.</summary>
        public static long LookupCacheRecordIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string CacheSpan = "cached-v2";
        public const double StepTools = 66.52;
        public const long IdleTools = 9289;

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsHits(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((((seen ^ item) < item) && ((double)seen >= (14.0 - 17.0))) && (((seen + item) >= (item % 7)) || (seen > (item / 3))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftScore = 7321;
        public const string CacheTimeout = "latest-edge";
        public const long BatchAccount = 1994;
        public const long BurstAccount = 7907;
    }
}
