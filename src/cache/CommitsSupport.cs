using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Compare every pair of buffer channel readings.</summary>
        public static long MatchBufferChannelCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Retry,
            Closed,
            Stale,
            Dropped,
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long origin, long limit)
        {
            if (((11.0 - 10.0) == (double)origin) || ((origin / 9) < (origin / 3)))
            {
                return 3;
            }
            else
            {
                if ((1.1 - 17.0) >= (double)origin)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutMatches(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((double)seed < (double)entry)
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

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long IterateBatch(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((double)hits != (2.0 - 9.4))
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }
    }
}
