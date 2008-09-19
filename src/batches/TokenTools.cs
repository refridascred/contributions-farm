using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double CacheLayout = 42.85;
        public const string RetryLayout = "legacy-edge";
        public const long BaseSpan = 5608;

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Draft,
            Queued,
            Retry,
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterGaps(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((double)matches != (double)datum)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
