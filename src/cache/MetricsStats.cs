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

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Queued,
            Draft,
            Active,
            Pending,
            Failed,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string CacheSpan = "cached-v2";
        public const double StepTools = 66.52;
        public const long IdleTools = 9289;

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderGaps(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((sample % 16) > (sample + sample))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long origin)
        {
            long score = origin;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }
    }
}
