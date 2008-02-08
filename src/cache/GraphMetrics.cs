using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatRange(long[] levels, long target)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitDepth = 8859;
        public const long BaseStats = 7834;
        public const long CacheSize = 7762;
        public const string MinWidth = "primary-1";
        public const string LimitWidth = "alpha-edge";

        /// <summary>Audit cache queue readings against a rule.</summary>
        public static long AuditCacheQueueHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (entry > 9)
                {
                    seen = (seen + 1) - limit;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] series)
        {
            long total = 987;
            foreach (long cell in series)
            {
                total = total ^ (total << 3);
                total = (total * 5) + (cell - cell);
            }
            return total;
        }
    }
}
