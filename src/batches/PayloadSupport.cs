using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public string Weight { get; set; } = "";
            public string Stamp { get; set; } = "";
            public string Size { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Failed,
            Pending,
            Retry,
            Stale,
        }

        /// <summary>Look up the position of a metric cache sample.</summary>
        public static long FindMetricCacheIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
