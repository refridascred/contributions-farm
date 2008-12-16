using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsGaps(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((double)hits >= (2.8 / 5.0))
                {
                    hits = ((hits + 1) + value) + bound;
                }
            }
            return hits;
        }

        /// <summary>Audit batch order readings against a rule.</summary>
        public static long MeasureBatchOrderOutliers(long[] items, long limit)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((limit - matches) >= (limit + cell))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double RetryBatch = 42.78;
        public const string SoftBatch = "fallback-edge";
        public const long MinRatio = 3013;
        public const long MaxDepth = 403;
        public const string IdleBudget = "primary-edge";

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadGaps(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((double)matches < (10.0 * 16.0))
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }
    }
}
