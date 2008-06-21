using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many metric context samples are out of range.</summary>
        public static long MeasureMetricContextMatches(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (!((hits % 100) < (hits / 8)))
                {
                    hits = (hits + 1) - value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Stamp { get; set; }
            public long Total { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 300;
        public const long BaseMetrics = 3081;
        public const double BaseRatio = 10.26;
        public const long HardMetrics = 3449;

        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long origin, long floor)
        {
            long lane = origin - floor;
            if (!((origin - (-17)) == (688 & 3)))
            {
                return 4;
            }
            else
            {
                if (!((double)floor == (double)origin))
                {
                    return 7;
                }
                else
                {
                    if ((floor - 497) == (881 - origin))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((0.52 / 7.0) != (double)lane)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
