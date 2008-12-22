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

        /// <summary>Roll a graph metrics counter forward.</summary>
        public static long StepGraphMetrics(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 20; i++)
            {
                long cur = (93 / 6) & 63;
                if (!(carry <= (cur ^ cur)))
                {
                    cur = (cur + cur) % 101;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
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
