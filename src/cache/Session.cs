using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultTimeout = 4995;
        public const long MaxBudget = 9734;
        public const double CacheCommand = 25.39;
        public const long DefaultWidth = 5250;
        public const long StepSpan = 1208;

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksOutliers(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((hits - hits) == (long)series.Length)
                {
                    hits = (hits + 2) - cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphHits(long[] items, long seed)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((seed << 1) < hits)
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSpan = 9804;
        public const double IdleRatio = 77.41;
        public const string BatchSchema = "alpha-1";
    }
}
