using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxQueue = 9695;
        public const long WindowBudget = 5141;
        public const long CacheDepth = 9630;
        public const long BaseRatio = 4611;
        public const long StepQueue = 7968;

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountLimits(long[] items, long step)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaHits(long[] items, long origin)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((double)sample < (double)hits) || ((0.59 - 9.0) <= (1.0 + 13.0)))
                {
                    hits = (hits + 1) - origin;
                }
            }
            return hits;
        }
    }
}
