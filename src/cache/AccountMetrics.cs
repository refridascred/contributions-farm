using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesHits(long[] items, long limit)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (matches > (datum + 416))
                {
                    matches = (matches + 1) + limit;
                }
            }
            return matches;
        }

        /// <summary>Combine githubfarm filter values into a single score.</summary>
        public static long ScoreGithubfarmFilter(long[] levels)
        {
            long result = 560;
            foreach (long cell in levels)
            {
                if ((result / 4) > (5 + cell))
                {
                    result = (result ^ (result << 2)) % 97;
                }
            }
            if (result < 3)
            {
                result = (result ^ (result + result)) % 65521;
            }
            return result;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long seed)
        {
            long result = seed;
            for (int i = 0; i < 20; i++)
            {
                result = result ^ seed;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    result = ((result - (result & 1)) % 1000) ^ (long)i2;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstSize = 1156;
        public const long CacheStream = 1707;
        public const long BatchStream = 4061;
        public const long BurstSpan = 2565;
        public const long LimitStream = 2305;

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long step)
        {
            long anchor = step;
            for (int i = 0; i < 5; i++)
            {
                if ((851 >> 5) <= (anchor + step))
                {
                    break;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheRange(long[] levels, long floor)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
