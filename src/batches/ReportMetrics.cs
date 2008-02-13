using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public string Region { get; set; } = "";
            public bool Score { get; set; }
            public bool Size { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Size { get; set; }
            public double Ratio { get; set; }
        }
    }
}
