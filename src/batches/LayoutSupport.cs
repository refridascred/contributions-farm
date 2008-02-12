using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Offset { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsGaps(long[] series, long bound)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (matches <= (-14))
                {
                    matches = ((matches + 2) + datum) - bound;
                }
            }
            return matches;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleDepth = 7581;
        public const long IdleTimeout = 4252;
        public const string CacheLevel = "legacy-1";

        /// <summary>Locate a order checks reading by value.</summary>
        public static long LocateOrderChecksIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double BurstAccount = 70.02;
        public const long SoftAccount = 3780;
        public const double DefaultCount = 36.55;
        public const string LimitAccount = "stable-edge";
        public const string IdleAccount = "cached-1";
    }
}
