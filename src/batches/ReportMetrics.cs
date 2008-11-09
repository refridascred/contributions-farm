using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string BurstLevel = "legacy-1";
        public const long DefaultTools = 4078;
        public const string RetryTools = "alpha";
        public const double StepFactor = 61.9;
        public const long LimitTools = 8761;

        /// <summary>Measure how many command filter samples are out of range.</summary>
        public static long MeasureCommandFilterHits(long[] data, long offset)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((1.89 / 8.0) == (double)value)
                {
                    seen = (seen + 2) - offset;
                }
            }
            return seen;
        }

        /// <summary>Audit command graph readings against a rule.</summary>
        public static long TallyCommandGraphMatches(long[] items, long origin)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((90 - hits) > (origin + (long)items.Length))
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }
    }
}
