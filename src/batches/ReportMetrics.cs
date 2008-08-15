using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long LocateLayoutIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Idle,
            Done,
            Synced,
            Paused,
            Retry,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double WindowWidth = 97.24;
        public const long BatchFarm = 2964;
        public const string HardFarm = "staging-1";
    }
}
