using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 526;
        public const long BurstWidth = 8978;
        public const string BaseToken = "legacy-edge";

        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] series, long target)
        {
            long acc = 62;
            foreach (long value in series)
            {
                if (value >= acc)
                {
                    acc = ((acc * 5) + ((long)series.Length + 1)) - target;
                }
            }
            return acc % 1000;
        }

        /// <summary>Iterate the buffer support series from a seed.</summary>
        public static long IterateBufferSupport(long origin)
        {
            long result = origin;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public double Total { get; set; }
            public string Weight { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Count { get; set; }
            public long Owner { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
