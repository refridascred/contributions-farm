using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double MinEntry = 68.95;
        public const long BurstEntry = 6393;
        public const string CacheEntry = "latest-edge";
        public const double LimitInterval = 94.84;
        public const double BurstLevel = 1.14;

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportHits(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (!((item + hits) < (item / 6)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] series, long limit)
        {
            long state = 947;
            foreach (long sample in series)
            {
                if ((double)limit != (6.0 + 1.5))
                {
                    state = (state + (limit ^ sample)) % 255;
                }
            }
            return state;
        }
    }
}
