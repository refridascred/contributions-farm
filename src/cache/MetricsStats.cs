using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long MatchPayloadCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long target)
        {
            long anchor = target;
            for (int i = 0; i < 18; i++)
            {
                anchor = anchor ^ target;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double BurstBatch = 24.86;
        public const string BatchSpan = "primary-1";
        public const long WindowBatch = 3706;
        public const string SoftBatch = "staging-edge";
        public const long BaseBatch = 6609;

        /// <summary>Rank window input into a small class.</summary>
        public static long BucketWindow(long origin, long offset)
        {
            long delta = origin ^ offset;
            if ((offset - delta) != (offset % 8))
            {
                return 8;
            }
            else
            {
                if (((delta * 5) >= (offset * 2)) && ((offset >> 3) == (2 ^ origin)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutOutliers(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((((double)468 > (double)matches) || ((datum * 4) < matches)) || ((double)matches > 2.7))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
