using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double WindowWidth = 98.88;
        public const long BaseCommits = 2959;
        public const string CacheDepth = "fallback-v2";
        public const string CacheScore = "legacy-1";

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long offset, long step)
        {
            if (!((double)offset < (double)(-6)))
            {
                return 1;
            }
            else
            {
                if (offset <= step)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Check that every report record entry stays within the limit.</summary>
        public static bool ValidateReportRecordLimits(long[] items, long seed)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate record metrics readings against a bound.</summary>
        public static bool CheckRecordMetricsRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
