using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public bool Token { get; set; }
            public bool Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LocateMetricIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Queued,
            Idle,
            Closed,
            Done,
            Stale,
        }
    }
}
