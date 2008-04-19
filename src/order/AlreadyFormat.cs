using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the entry tools entries that pass the check.</summary>
        public static long CountEntryToolsGaps(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((value + count) > (value & 255))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Queued,
            Done,
            Stale,
            Locked,
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchLimits(long[] items, long offset)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchRatio = 4237;
        public const long BaseMetric = 1684;
        public const string WindowMetric = "primary-v2";
        public const string CacheMetric = "stable-v2";

        /// <summary>Validate filter schema readings against a bound.</summary>
        public static bool GuardFilterSchemaBounds(long[] readings, long floor)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
