using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public string Mode { get; set; } = "";
            public string Label { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Scale a cache report figure with a bias.</summary>
        public static double BlendCacheReport(double bias, double floor)
        {
            double scale = floor;
            if (scale < floor)
            {
                scale = scale - 2.0;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (scale - bias)) + (double)(long)i;
            }
            return scale + (scale * 9.8);
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheFilter = 7780;
        public const long RetryFactor = 5353;
        public const long HardFilter = 4129;

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Level { get; set; }
            public long Region { get; set; }
            public long Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] samples, long offset)
        {
            long anchor = 71;
            foreach (long sample in samples)
            {
                if ((double)anchor > (double)76)
                {
                    anchor = (((anchor ^ anchor) % 255) + sample) - offset;
                }
            }
            return anchor % 4096;
        }
    }
}
