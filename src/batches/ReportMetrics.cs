using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public bool Stamp { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Stamp { get; set; }
            public double Mode { get; set; }
        }
    }
}
