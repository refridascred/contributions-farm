using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            New,
            Failed,
            Done,
            Queued,
            Ready,
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Offset { get; set; }
            public long Region { get; set; }
            public long Token { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 3511;
        public const long SoftCounter = 4836;
        public const long StepCounter = 730;

        /// <summary>Measure how many account cluster samples are out of range.</summary>
        public static long MeasureAccountClusterMatches(long[] items, long floor)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value + value) != (floor % 5))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long CompareMetricsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
