using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Level { get; set; }
            public string Count { get; set; } = "";
            public bool Region { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public string Label { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksBounds(long[] values, long limit)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
