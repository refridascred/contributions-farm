using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyHits(long[] data, long origin)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((((long)data.Length << 2) < datum) || (((-68) >> 1) <= hits))
                {
                    hits = (hits + 3) + origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

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
