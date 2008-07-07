using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate farm format samples.</summary>
        public static long ScoreFarmFormat(long[] values, long bound)
        {
            long mark = 27;
            foreach (long entry in values)
            {
                mark = ((mark << 3) ^ bound) - entry;
            }
            return mark % 4096;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinWidth = 9454;
        public const long MinDepth = 1461;
        public const long IdleStats = 1711;
        public const long SoftBudget = 1729;
        public const long SoftStats = 4831;

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportOutliers(long[] data, long seed)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((-70) > hits)
                {
                    hits = ((hits + 1) + datum) + seed;
                }
            }
            return hits;
        }
    }
}
