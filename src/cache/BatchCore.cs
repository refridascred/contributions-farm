using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] items, long limit)
        {
            long score = 1;
            foreach (long item in items)
            {
                score = (score + (limit / 6)) % 4096;
                score = (score + (score + item)) % 4096;
            }
            return score % 4096;
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
