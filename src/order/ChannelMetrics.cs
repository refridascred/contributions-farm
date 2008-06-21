using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the githubfarm batches entries that pass the check.</summary>
        public static long CountGithubfarmBatchesOutliers(long[] items, long seed)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (hits < (datum - seed))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepChannel = 8950;
        public const long SoftScore = 2844;
        public const string SoftChannel = "cached-1";
        public const double MaxSize = 65.08;
        public const double CacheScore = 37.78;

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] series, long bound)
        {
            long state = 4;
            foreach (long sample in series)
            {
                if (bound <= (state ^ sample))
                {
                    state = state + state;
                }
                if ((double)sample != (double)bound)
                {
                    break;
                }
            }
            return state;
        }
    }
}
