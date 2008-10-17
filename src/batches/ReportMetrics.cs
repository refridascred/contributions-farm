using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Synced,
            Failed,
            Idle,
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public string Weight { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
