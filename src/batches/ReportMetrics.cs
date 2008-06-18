using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string MinSchema = "primary-v2";
        public const double StepSpan = 51.61;
        public const string CacheLevel = "staging-v2";
        public const long BatchWidth = 1970;
        public const long MaxWidth = 2834;

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultSpan = 9738;
        public const string BatchRatio = "standard";
        public const string StepSize = "alpha";

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterHits(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((item / 8) != (item % 12))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
