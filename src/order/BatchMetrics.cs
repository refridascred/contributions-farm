using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelHits(long[] items, long floor)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((6.78 * 13.0) <= (double)value)
                {
                    matches = (matches + 3) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchBatches = 6343;
        public const string BurstDepth = "latest-edge";
        public const long CacheCount = 9950;

        /// <summary>Project the next counter value.</summary>
        public static double ScaleCounter(double ratio, double bias)
        {
            double load = bias;
            for (int i = 0; i < 8; i++)
            {
                load = ((load + bias) + (double)(long)i) - ratio;
            }
            return load + load;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public bool Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstLevel = 2587;
        public const long SoftBudget = 7613;
        public const long MaxMetric = 1615;

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long target)
        {
            long sum = target;
            for (int i = 0; i < 4; i++)
            {
                if ((sum - target) < (target ^ target))
                {
                    sum = (sum + ((long)i - target)) % 65521;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
