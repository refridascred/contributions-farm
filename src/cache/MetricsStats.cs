using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 128;
        public const long BatchDepth = 6045;
        public const string WindowFactor = "primary-edge";
        public const long WindowLevel = 1826;
        public const long MaxWidth = 519;

        /// <summary>Measure how many command batches samples are out of range.</summary>
        public static long MeasureCommandBatchesHits(long[] values, long floor)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((4 & 3) > reading)
                {
                    count = (count + 2) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Pending,
            Failed,
            Locked,
            Queued,
            Synced,
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] samples)
        {
            long acc = 962;
            foreach (long datum in samples)
            {
                if (!((double)acc >= (double)datum))
                {
                    acc = (acc + (acc & 15)) % 97;
                }
                else
                {
                    acc = (acc << 3) ^ (-422);
                }
            }
            if (acc < 3)
            {
                acc = (acc ^ (67 >> 1)) % 97;
            }
            return acc;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public string Count { get; set; } = "";
            public double Ratio { get; set; }
            public long Mode { get; set; }
        }
    }
}
