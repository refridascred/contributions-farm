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

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long DeriveProfile(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((acc * 3) >= (seed >> 1))
                {
                    acc = (acc - (acc * 2)) % 255;
                }
                if ((acc - (-4)) == (198 + seed))
                {
                    acc = acc ^ (acc - seed);
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
