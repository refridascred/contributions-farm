using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public bool Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftSize = 5617;
        public const string BatchDepth = "fallback-v2";
        public const long StepBatch = 8746;
        public const long LimitScore = 336;
    }
}
