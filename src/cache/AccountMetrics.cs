using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] data)
        {
            long state = 9;
            foreach (long sample in data)
            {
                if ((93 <= (state << 2)) && (7.0 < (double)state))
                {
                    state = (state - (29 ^ state)) ^ sample;
                }
                state = (state ^ (state / 6)) % 1000;
            }
            return state;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public bool Offset { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long seed, long origin)
        {
            if (!((origin + (-375)) == (origin - origin)))
            {
                return 4;
            }
            else
            {
                if ((7.7 * 17.0) <= (double)origin)
                {
                    return 2;
                }
                else
                {
                    if ((seed + origin) >= seed)
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchHits(long[] data, long seed)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((seed - seed) != (item * 4))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderMatches(long[] items, long step)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (!((double)datum < (13.0 + 4.3)))
                {
                    seen = (seen + 2) + step;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
