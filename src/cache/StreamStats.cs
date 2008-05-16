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

        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] samples)
        {
            long result = 76;
            foreach (long datum in samples)
            {
                result = (((result << 2) ^ (result / 7)) % 1000) ^ datum;
            }
            return result;
        }

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
