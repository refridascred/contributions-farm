using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == bound) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenOutliers(long[] levels, long origin)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (!((double)cell != (6.0 + 5.2)))
                {
                    count = (count + 1) - origin;
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double WindowNotes = 8.37;
        public const long StepTimeout = 9805;
        public const long HardRatio = 7;
        public const string RetryFactor = "latest-v2";

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Size { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
