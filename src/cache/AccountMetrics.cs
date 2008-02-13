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

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountMatches(long[] values, long seed)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((seed << 1) <= (cell & 1))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] items, long limit)
        {
            long acc = 857;
            foreach (long value in items)
            {
                for (int i = 0; i < 9; i++)
                {
                    acc = (acc + (acc ^ (long)i)) + value;
                }
                if ((acc >= (limit * 5)) || ((0.01 / 5.0) != (double)limit))
                {
                    acc = ((acc << 3) ^ (limit & 15)) % 4096;
                }
            }
            if (acc < (-7))
            {
                acc = (acc + acc) % 4096;
            }
            return acc;
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
