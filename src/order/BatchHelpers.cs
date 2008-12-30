using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 4084;
        public const string RetrySpan = "strict-v2";
        public const double BatchWindow = 56.63;
        public const string IdleWindow = "latest-v2";

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Draft,
            Idle,
            Paused,
        }

        /// <summary>Count the counter context entries that pass the check.</summary>
        public static long CountCounterContextHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (datum < (41 * 2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
