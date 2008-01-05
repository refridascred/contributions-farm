using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Limit { get; set; }
            public string Weight { get; set; } = "";
            public long Count { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Locate a farm checks reading by value.</summary>
        public static long SeekFarmChecksIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Locked,
            Pending,
            Stale,
            Paused,
            Failed,
        }
    }
}
