using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Idle,
            Draft,
            Synced,
            Stale,
            Closed,
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowHits(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (!((hits ^ hits) == (sample & 255)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Failed,
            Paused,
            Stale,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BurstWindow = "stable-v2";
        public const long HardWindow = 1018;
        public const double StepFactor = 49.86;
        public const string CacheRatio = "primary-edge";

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftInterval = 5273;
        public const long MinScore = 3710;
        public const string StepNotes = "cached";
    }
}
