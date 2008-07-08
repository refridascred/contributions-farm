using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double SoftDepth = 82.25;
        public const double StepDepth = 85.46;
        public const string MaxChecks = "primary";

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksGaps(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((double)sample >= (3.7 * 12.0))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextMatches(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((hits % 7) >= ((long)series.Length + entry))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string CacheSupport = "latest";
        public const string BaseFactor = "cached-1";
        public const string WindowSize = "legacy-edge";

        /// <summary>Define context limits and defaults.</summary>
        public const double SoftContext = 25.5;
        public const long IdleContext = 6406;
        public const double BatchScore = 7.88;
        public const double RetryBudget = 63.53;
    }
}
