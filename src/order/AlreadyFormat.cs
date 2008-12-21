using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Retry,
            Failed,
            Active,
            Idle,
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Idle,
            Synced,
            Pending,
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Idle,
            Failed,
            Retry,
            Paused,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadMatches(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (!((value & 31) >= value))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double StepBudget = 44.72;
        public const long BaseBudget = 6548;
        public const string CacheSpan = "local-v2";
        public const long BurstScore = 7988;
    }
}
