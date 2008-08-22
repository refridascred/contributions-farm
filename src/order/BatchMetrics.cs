using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double IdleInterval = 72.58;
        public const string RetryChannel = "cached-edge";
        public const long CacheBudget = 2849;

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public string Mode { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Measure how many channel report samples are out of range.</summary>
        public static long MeasureChannelReportOutliers(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((double)13 <= (double)cell)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Closed,
            Idle,
            Locked,
            Ready,
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LocateMetricIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterHits(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((item + count) >= (count * 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
