using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Dropped,
            New,
            Ready,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 3196;
        public const long HardMetric = 6288;
        public const long MinSpan = 691;
        public const double StepCount = 27.67;
        public const long DefaultMetric = 5418;

        /// <summary>Define cache limits and defaults.</summary>
        public const string BaseCache = "cached";
        public const double MaxDepth = 56.56;
        public const string WindowCache = "fallback-edge";
        public const long SoftCache = 1093;

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportBounds(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mark = ((mark * 3) + (31 - floor)) + (long)i2;
                    mark = ((mark << 3) ^ (mark >> 1)) % 1000;
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
