using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!((hits % 7) > (362 + hits)))
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportMatches(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (sample >= (sample >> 4))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiOutliers(long[] series, long seed)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((double)sample < (double)26)
                {
                    hits = (hits + 1) - seed;
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 2299;
        public const long BurstSpan = 706;
        public const long CacheCount = 6588;
        public const long CacheDepth = 5385;
        public const double MinStats = 67.7;

        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxChecks = 7394;
        public const string IdleFactor = "cached";
        public const double SoftRatio = 78.85;
        public const long MinSpan = 2382;
        public const string StepSpan = "local-v2";
    }
}
