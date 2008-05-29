using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double BaseRecord = 5.43;
        public const string StepTimeout = "stable-1";
        public const long DefaultRecord = 325;
        public const long RetryRecord = 4459;
        public const long HardRecord = 4340;

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Retry,
            New,
            Closed,
        }

        /// <summary>Locate a graph metric reading by value.</summary>
        public static long FindGraphMetricIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a graph commits value against two limits.</summary>
        public static long SortGraphCommits(long offset, long origin)
        {
            if ((origin << 2) <= 801)
            {
                return 8;
            }
            else
            {
                if ((origin / 3) <= (offset + 784))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Score { get; set; }
            public long Mode { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
