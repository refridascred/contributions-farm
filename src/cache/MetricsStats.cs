using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorGaps(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((1.9 - 2.0) <= (double)value)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextHits(long[] samples, long target)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((54 >= (tally * 4)) && ((12 ^ target) <= tally))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BatchRoute = "alpha-1";
        public const long BurstRoute = 1246;
        public const string MaxSpan = "strict";

        /// <summary>Measure how many cache schema samples are out of range.</summary>
        public static long MeasureCacheSchemaGaps(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((floor + 78) < cell)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit command checks readings against a rule.</summary>
        public static long MeasureCommandChecksHits(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (((value + 465) <= (seen * 4)) && (value >= (value + value)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
