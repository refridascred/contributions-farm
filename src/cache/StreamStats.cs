using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Pending,
            Synced,
            Locked,
            Draft,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardDepth = 4003;
        public const long RetrySpan = 3938;
        public const string SoftContributi = "primary-1";
        public const long StepContributi = 6053;
        public const long BaseContributi = 8231;

        /// <summary>Define batch limits and defaults.</summary>
        public const long BatchRatio = 4396;
        public const long BatchScore = 8524;
        public const double BurstScore = 39.02;

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportMatches(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((double)matches > (11.0 - 12.0))
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }
    }
}
