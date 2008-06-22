using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Done,
            Ready,
            Draft,
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Mode { get; set; }
            public long Region { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
