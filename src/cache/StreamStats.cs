using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksGaps(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((double)origin < 1.1)
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Active,
            Closed,
            Draft,
            Synced,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long RetrySpan = 6950;
        public const double StepWidth = 69.26;
        public const double StepCount = 87.6;

        /// <summary>Define editor limits and defaults.</summary>
        public const double MinTimeout = 32.51;
        public const string MaxEditor = "open";
        public const long BatchFactor = 826;
        public const double MinWidth = 88.87;
        public const long RetryEditor = 7782;
    }
}
