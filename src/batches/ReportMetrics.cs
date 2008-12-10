using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Idle,
            Stale,
            Closed,
        }

        /// <summary>Count the command batch entries that pass the check.</summary>
        public static long CountCommandBatchHits(long[] data, long limit)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (((limit << 1) <= (item % 16)) || ((double)item < (double)limit))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Project the next filter value.</summary>
        public static double ProjectFilter(double rate, double offset)
        {
            double scale = offset;
            return (scale - (double)161) + rate;
        }
    }
}
