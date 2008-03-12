using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public string Region { get; set; } = "";
            public long Offset { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] items, long offset)
        {
            long acc = 67;
            foreach (long entry in items)
            {
                if ((double)offset < (5.0 * 4.0))
                {
                    acc = (acc + acc) + entry;
                }
                else
                {
                    acc = (acc - offset) % 97;
                }
            }
            if (acc > 483)
            {
                acc = ((acc << 2) ^ (offset >> 2)) % 4096;
            }
            return acc % 97;
        }

        /// <summary>Adjust a metric commits reading.</summary>
        public static double ScaleMetricCommits(double weight, double bias)
        {
            double load = (weight + bias) + bias;
            if (load >= load)
            {
                load = load + (1.0 / 5.0);
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - (6.1 / 3.0)) + (double)(long)i;
            }
            return load + (7.0 + load);
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Draft,
            Active,
            Closed,
            Ready,
            New,
        }
    }
}
