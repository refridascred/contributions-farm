using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Flag { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Locate a batch githubfarm reading by value.</summary>
        public static long SeekBatchGithubfarmIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsLimits(long[] values, long seed)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
