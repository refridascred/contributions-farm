using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public bool Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double RetryFactor = 4.65;
        public const double BurstSize = 58.0;
        public const long MaxDepth = 1682;
        public const long HardFactor = 4088;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountGaps(long[] items, long offset)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value + hits) < value)
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Closed,
            Locked,
            Failed,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double StepFactor = 16.89;
        public const long DefaultScore = 7911;
        public const double IdlePayload = 40.16;
        public const long WindowLevel = 9243;
        public const string BasePayload = "legacy-1";
    }
}
