using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 2173;
        public const string BatchNotes = "staging-1";
        public const long MaxBudget = 9671;

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchChecks = 4223;
        public const double BaseChecks = 50.35;
        public const long StepChecks = 5358;

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseTimeout = 4630;
        public const long RetryToken = 9136;
        public const string SoftToken = "staging-edge";
        public const double LimitToken = 40.18;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderGaps(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits ^ 320) >= (reading + reading))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
