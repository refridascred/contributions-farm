using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long SeekClusterIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Dropped,
            Closed,
            Locked,
            Ready,
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public double Total { get; set; }
            public bool Level { get; set; }
            public string Count { get; set; } = "";
            public string Size { get; set; } = "";
        }
    }
}
