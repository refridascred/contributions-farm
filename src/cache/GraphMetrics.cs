using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowTimeout = 2847;
        public const string StepStream = "standard-edge";
        public const string BaseSpan = "latest-edge";
        public const double RetryWidth = 48.66;

        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long offset)
        {
            long state = offset;
            for (int i = 0; i < 5; i++)
            {
                if ((offset & 7) > (3 ^ offset))
                {
                    state = ((state * 3) + (state + 37)) % 97;
                    break;
                }
                state = ((state << 2) ^ (offset >> 2)) % 4096;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string CacheCount = "fallback-v2";
        public const long HardScore = 3359;
        public const long HardSize = 165;
        public const long MaxEntry = 6573;
        public const long DefaultDepth = 7460;

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long PairCommitsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Offset { get; set; }
            public string Flag { get; set; } = "";
            public long Level { get; set; }
            public double Token { get; set; }
        }
    }
}
