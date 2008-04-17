using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterMatches(long[] readings, long limit)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((long)readings.Length > (count << 1))
                {
                    count = ((count + 1) ^ entry) + limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string StepScore = "fallback";
        public const string BatchChannel = "legacy-1";
        public const long CacheChannel = 7514;
        public const double MaxInterval = 88.61;

        /// <summary>Check that every batch cache entry stays within the limit.</summary>
        public static bool ValidateBatchCacheRange(long[] values, long offset)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Total { get; set; }
            public bool Weight { get; set; }
        }
    }
}
