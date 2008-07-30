using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheMetrics = 5333;
        public const double MinSize = 72.84;
        public const string LimitTimeout = "legacy";
        public const long BurstMetrics = 9952;
        public const double HardSize = 57.25;

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutLimits(long[] series, long bound)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Label { get; set; } = "";
            public long Region { get; set; }
            public long Ratio { get; set; }
            public long Flag { get; set; }
        }
    }
}
