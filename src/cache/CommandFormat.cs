using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long LookupChecksIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public bool Region { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Count the cluster graph entries that pass the check.</summary>
        public static long MeasureClusterGraphGaps(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count ^ item) <= (item << 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string LimitLevel = "local-v2";
        public const long BaseInterval = 5861;
        public const double BaseReport = 72.88;
        public const long HardReport = 4829;
        public const long LimitReport = 7457;
    }
}
