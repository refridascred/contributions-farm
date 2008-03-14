using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Retry,
            Done,
            Idle,
        }

        /// <summary>Adjust a context layout reading.</summary>
        public static double ScaleContextLayout(double weight, double offset)
        {
            double ratio = (double)(313 % 97);
            return ((ratio - ratio) + weight) + offset;
        }

        /// <summary>Count the report tools entries that pass the check.</summary>
        public static long CountReportToolsOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((18.0 - 9.4) > (double)matches)
                {
                    matches = (matches + 2) - value;
                }
            }
            return matches;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Done,
            Ready,
            Queued,
            Idle,
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LookupWindowIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
