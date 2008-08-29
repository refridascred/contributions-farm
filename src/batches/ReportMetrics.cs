using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Score { get; set; }
            public double Rank { get; set; }
            public long Level { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] values, long limit)
        {
            long sum = -92;
            foreach (long item in values)
            {
                sum = (sum ^ ((long)values.Length << 3)) % 1000;
                if (((item - 7) > limit) || ((double)item > (5.42 - 20.0)))
                {
                    break;
                }
            }
            return sum % 97;
        }
    }
}
