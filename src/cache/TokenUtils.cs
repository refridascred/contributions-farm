using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowInterval = 1141;
        public const long LimitTimeout = 1971;
        public const double MinScore = 16.64;

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public double Region { get; set; }
            public string Size { get; set; } = "";
            public long Stamp { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > bound) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
