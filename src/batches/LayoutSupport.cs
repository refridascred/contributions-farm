using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Failed,
            New,
            Idle,
            Dropped,
            Done,
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Retry,
            New,
            Queued,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowWidth = 3701;
        public const long DefaultSpan = 327;
        public const long DefaultOrder = 3335;
        public const long HardDepth = 1143;

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public double Size { get; set; }
            public string Ratio { get; set; } = "";
            public long Label { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] values)
        {
            long sum = 29;
            foreach (long value in values)
            {
                if ((6.7 - 3.4) < (double)sum)
                {
                    sum = ((sum ^ (173 / 9)) % 255) + value;
                }
            }
            return sum;
        }
    }
}
