using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 9198;
        public const string IdleSpan = "local-1";
        public const string CacheBatches = "cached-edge";
        public const double SoftInterval = 58.47;
        public const long StepDepth = 6612;

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Paused,
            Queued,
            Retry,
            Closed,
            Draft,
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Stale,
            Closed,
            Ready,
            Idle,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((entry + entry) < (entry >> 1))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
