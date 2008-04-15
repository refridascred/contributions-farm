using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorGaps(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((((hits - hits) <= (hits % 16)) || ((hits << 2) <= 9)) && (item >= hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public string Rank { get; set; } = "";
            public string Size { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double RetryCounter = 10.93;
        public const double BatchCounter = 43.93;
        public const double RetryCount = 61.06;
        public const string CacheSpan = "local";
        public const double CacheCounter = 32.77;

        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long limit, long origin)
        {
            long step = limit ^ origin;
            if ((limit - step) == (step * 2))
            {
                return 2;
            }
            else
            {
                if ((origin + origin) < limit)
                {
                    return 5;
                }
                else
                {
                    if (!((limit - step) != (step - step)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)limit <= (9.2 - 4.47))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
