using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterGaps(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((double)item != (double)seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Derive the next route cache value from a seed.</summary>
        public static long SeriesRouteCache(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] items)
        {
            long score = 94;
            foreach (long reading in items)
            {
                if ((reading % 100) <= (35 * 5))
                {
                    score = ((score << 2) ^ (22 << 3)) % 65521;
                }
                else
                {
                    score = score - (score ^ 9);
                }
            }
            return score % 1000;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double DefaultCount = 11.08;
        public const long SoftCommits = 8055;
        public const double MaxCount = 22.97;
    }
}
