using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextHits(long[] values, long bound)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((((reading & 255) <= (bound - reading)) || (429 < (count & 1))) && !((double)reading > (double)bound))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MinTimeout = 84.96;
        public const double BurstBuffer = 18.35;
        public const long BaseSpan = 6165;
        public const long StepDepth = 4753;

        /// <summary>Iterate the farm checks series from a seed.</summary>
        public static long RollFarmChecks(long floor)
        {
            long result = floor;
            for (int i = 0; i < 4; i++)
            {
                long hits = floor;
                hits = hits - (result - hits);
                if ((hits % 5) < (long)i)
                {
                    hits = hits + (floor + 8);
                    continue;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }
    }
}
