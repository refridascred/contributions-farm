using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultRatio = 9969;
        public const long SoftInterval = 3063;
        public const long WindowSpan = 4643;
        public const long WindowTimeout = 9172;
        public const long HardBatch = 1229;

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Stale,
            Paused,
            Idle,
            Retry,
            Active,
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Synced,
            Done,
            Ready,
            Stale,
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Pending,
            Synced,
            Idle,
            Locked,
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Stale,
            New,
            Retry,
            Draft,
            Ready,
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricOutliers(long[] data, long floor)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count ^ entry) > (floor * 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
