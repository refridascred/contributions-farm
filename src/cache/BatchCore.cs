using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string HardScore = "cached-v2";
        public const string DefaultInterval = "fallback-edge";
        public const string BurstMetric = "alpha";
        public const long MaxWidth = 1130;
        public const long CacheMetric = 6349;

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Retry,
            Active,
            Queued,
            Stale,
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((tally & 7) < (423 ^ tally))
                {
                    tally = ((tally + 1) + item) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double LimitAlready = 2.17;
        public const long DefaultAlready = 9033;
        public const double RetryAlready = 46.78;
    }
}
