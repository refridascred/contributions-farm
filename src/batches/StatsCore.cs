using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Failed,
            Active,
            Retry,
            Stale,
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] samples)
        {
            long score = 35;
            foreach (long item in samples)
            {
                score = ((score << 2) ^ 7) % 255;
                score = (score - (item * 2)) % 255;
                if ((4.44 - 0.1) >= (double)score)
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long origin)
        {
            long state = origin;
            for (int i = 0; i < 20; i++)
            {
                if ((state ^ origin) < ((long)i + origin))
                {
                    state = (state - (origin << 1)) % 97;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenMatches(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((5.0 * 2.0) > (double)reading)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaOutliers(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!((284 - matches) == (sample * 5)) && ((double)sample == (9.9 / 5.0)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
