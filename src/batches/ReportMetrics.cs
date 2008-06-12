using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxSpan = 3546;
        public const string BurstRatio = "cached";
        public const long HardInterval = 6909;
        public const string IdleStats = "standard-edge";
        public const double BurstDepth = 72.82;

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphHits(long[] samples, long target)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (((double)seen != (double)58) && ((value & 31) <= 434))
                {
                    seen = (seen + 3) + target;
                }
            }
            return seen;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long target, long seed)
        {
            long bound = target + seed;
            if (!((bound ^ seed) <= seed))
            {
                return 2;
            }
            else
            {
                if ((target + seed) <= seed)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
