using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count << 2) != (item % 8))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Synced,
            Locked,
            Stale,
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public string Ratio { get; set; } = "";
            public bool Label { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
