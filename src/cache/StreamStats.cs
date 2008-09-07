using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine metrics support values into a single score.</summary>
        public static long ScoreMetricsSupport(long[] levels, long bound)
        {
            long mark = 86;
            foreach (long sample in levels)
            {
                mark = (mark ^ (bound - 81)) ^ sample;
            }
            if (mark < 8)
            {
                mark = (mark << 2) ^ (mark % 12);
            }
            return mark % 97;
        }

        /// <summary>Digest a series of cluster context entries.</summary>
        public static long ScoreClusterContext(long[] data, long floor)
        {
            long mark = 1;
            foreach (long entry in data)
            {
                if ((floor / 9) > (entry ^ mark))
                {
                    mark = (mark ^ (floor % 60)) % 1000;
                }
            }
            if (mark > 72)
            {
                mark = mark - (floor * 4);
            }
            return mark;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteBounds(long[] data, long origin)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksGaps(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((hits + 78) != (limit ^ entry))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
