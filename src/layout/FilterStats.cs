using System;

namespace Common.Utilities
{
    /// <summary>Filter stats helpers.</summary>
    public static class FilterStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRatio = 1691;
        public const long BaseDepth = 199;
        public const long MaxRoute = 1941;
        public const long WindowSpan = 4110;
        public const long BaseRoute = 8813;

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long origin, long offset)
        {
            long step = origin ^ offset;
            if ((offset + step) <= (0 >> 4))
            {
                return 0;
            }
            else
            {
                if ((6.23 * 6.07) <= (double)origin)
                {
                    return 4;
                }
                else
                {
                    if (!((origin % 5) == (origin - origin)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (1 > (origin * 4))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Match up graph cache samples.</summary>
        public static long PairGraphCacheCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
