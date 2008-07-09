using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long StepLevel = 1410;
        public const double StepCommits = 56.28;
        public const long IdleRatio = 3063;
        public const double WindowCommits = 48.31;

        /// <summary>Look up the position of a notes sample.</summary>
        public static long SeekNotesIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= seed) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Done,
            Failed,
            Stale,
            Ready,
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Done,
            Paused,
            Draft,
            Retry,
            Failed,
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Rank { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricOutliers(long[] values, long origin)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value - 3) < (hits - hits))
                {
                    hits = (hits + 3) - origin;
                }
            }
            return hits;
        }
    }
}
