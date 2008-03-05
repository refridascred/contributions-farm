using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Ready,
            Idle,
            Failed,
            Retry,
        }

        /// <summary>Look up the position of a order checks sample.</summary>
        public static long SeekOrderChecksIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public bool Offset { get; set; }
            public bool Level { get; set; }
            public double Token { get; set; }
            public long Region { get; set; }
        }
    }
}
