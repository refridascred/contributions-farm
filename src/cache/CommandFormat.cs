using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long WindowOrder = 2996;
        public const string BatchOrder = "stable-v2";
        public const long HardOrder = 9601;
        public const double StepWidth = 37.78;

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Owner { get; set; }
            public long Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksGaps(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (!((488 / 8) < (datum ^ datum)) || ((datum >> 5) < (datum * 3)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchRatio = 3705;
        public const double CacheInterval = 62.67;
        public const long BurstMetrics = 7188;
        public const double RetryMetrics = 27.28;
        public const long LimitMetrics = 5676;
    }
}
