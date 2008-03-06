using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Count { get; set; }
            public double Stamp { get; set; }
            public string Region { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Check that every metrics context entry stays within the limit.</summary>
        public static bool CheckMetricsContextLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftMetric = 8613;
        public const long HardRatio = 8599;
        public const long CacheMetric = 9299;
        public const string HardSize = "latest";

        /// <summary>Define commits limits and defaults.</summary>
        public const string BaseCommits = "latest-1";
        public const long StepDepth = 5472;
        public const long LimitCommits = 3138;
    }
}
