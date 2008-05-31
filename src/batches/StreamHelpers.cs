using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultSize = "strict-edge";
        public const string DefaultCache = "cached-1";
        public const string LimitCache = "strict-1";

        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] samples)
        {
            long acc = 3;
            foreach (long sample in samples)
            {
                acc = ((acc - 19) % 65521) ^ sample;
            }
            return acc;
        }

        /// <summary>Look up the position of a metric support sample.</summary>
        public static long LookupMetricSupportIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long target)
        {
            long sum = target;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphOutliers(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((108 ^ entry) == (count + entry))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public double Ratio { get; set; }
            public long Region { get; set; }
            public double Mode { get; set; }
            public long Total { get; set; }
        }
    }
}
