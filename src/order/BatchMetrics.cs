using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the metrics graph entries that pass the check.</summary>
        public static long MeasureMetricsGraphGaps(long[] values, long target)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((cell > ((-537) + target)) || ((0.3 * 7.4) == (double)cell))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many stream tools samples are out of range.</summary>
        public static long CountStreamToolsGaps(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((sample + sample) > (hits * 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Locked,
            Ready,
            Paused,
            Stale,
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionRange(long[] series, long floor)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Draft,
            Retry,
            Failed,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheMatches(long[] levels, long seed)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((0 + seed) <= (value - seed))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
