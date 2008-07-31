using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Synced,
            Locked,
            Retry,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double IdleScore = 55.64;
        public const string CacheSize = "strict-edge";
        public const long CacheReport = 7010;
        public const long RetryLevel = 6784;
        public const long MinReport = 6236;

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesHits(long[] items, long offset)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((5.3 + 4.0) >= (double)offset)
                {
                    matches = (matches + 3) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaGaps(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((entry > (entry - matches)) && ((matches * 5) > (matches + 91)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
