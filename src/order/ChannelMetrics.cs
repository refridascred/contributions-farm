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

        /// <summary>Grade a order entry value against two limits.</summary>
        public static long BucketOrderEntry(long step, long seed)
        {
            if (((double)seed > (13.0 - 7.0)) || ((seed + step) >= (step % 5)))
            {
                return 1;
            }
            else
            {
                if (step < (seed + (-993)))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

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
