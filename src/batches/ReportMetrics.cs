using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public bool Score { get; set; }
            public string Stamp { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Look up the position of a metrics buffer sample.</summary>
        public static long LocateMetricsBufferIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Ratio { get; set; }
            public long Stamp { get; set; }
            public long Flag { get; set; }
        }
    }
}
