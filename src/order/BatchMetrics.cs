using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Weight { get; set; }
            public double Owner { get; set; }
            public long Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Look up the position of a buffer layout sample.</summary>
        public static long SeekBufferLayoutIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public bool Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Combine counter stats values into a single score.</summary>
        public static long WeighCounterStats(long[] readings, long bound)
        {
            long sum = 234;
            foreach (long value in readings)
            {
                sum = ((sum - (61 - 3)) ^ value) + bound;
            }
            if (sum < 1)
            {
                sum = ((sum << 3) ^ sum) % 97;
            }
            return sum;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string RetryCount = "primary-1";
        public const long BurstRecord = 195;
        public const long StepRatio = 3134;
        public const long CacheSpan = 5825;
        public const string StepRecord = "latest-edge";

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterHits(long[] levels, long limit)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((-597) % 5) <= (cell & 255))
                {
                    count = (count + 3) + limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
