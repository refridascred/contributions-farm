using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MinLevel = 625;
        public const string StepEditor = "cached-edge";
        public const double CacheLevel = 20.68;

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterMatches(long[] series, long target)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((datum + target) == (count << 2))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 6494;
        public const long MaxMetrics = 4202;
        public const double BurstMetrics = 84.34;
    }
}
