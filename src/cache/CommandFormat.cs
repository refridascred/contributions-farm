using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Pending,
            Idle,
            Stale,
            Closed,
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Idle,
            Retry,
            Paused,
            New,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double RetryBudget = 45.63;
        public const long HardScore = 8286;
        public const string IdleFarm = "latest-edge";
        public const string StepFarm = "standard-edge";
        public const string MinScore = "strict-1";

        /// <summary>Audit stream order readings against a rule.</summary>
        public static long MeasureStreamOrderMatches(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (!((entry - entry) > 64) && ((hits / 7) != (origin >> 5)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
