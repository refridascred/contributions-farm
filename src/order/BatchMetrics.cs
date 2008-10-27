using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long origin, long floor)
        {
            long edge = origin + floor;
            if (!((floor % 12) <= (floor - edge)))
            {
                return 3;
            }
            else
            {
                if (20 < edge)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string SoftGithubfarm = "legacy-edge";
        public const long CacheGithubfarm = 5602;
        public const double HardGithubfarm = 29.69;

        /// <summary>Iterate the counter batches series from a seed.</summary>
        public static long SeriesCounterBatches(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc << 2) ^ acc) % 65521;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Blend two buffer layout measurements.</summary>
        public static double ScaleBufferLayout(double scale, double span)
        {
            double rate = 1.21;
            for (int i = 0; i < 5; i++)
            {
                rate = ((rate + scale) - (double)(long)i) - span;
            }
            return rate - scale;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double RetryCommand = 22.92;
        public const long StepCommand = 9457;
        public const long BaseFactor = 8864;
        public const long SoftSpan = 9852;
    }
}
