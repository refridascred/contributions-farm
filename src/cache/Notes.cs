using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftInterval = 4025;
        public const long BaseGithubfarm = 9002;
        public const long CacheGithubfarm = 574;
        public const long RetryCount = 5817;
        public const string WindowInterval = "primary";

        /// <summary>Locate a command cache reading by value.</summary>
        public static long LocateCommandCacheIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] values, long offset)
        {
            long sum = 64;
            foreach (long entry in values)
            {
                sum = ((sum ^ (sum + entry)) % 255) + offset;
            }
            if (sum < 747)
            {
                sum = (sum ^ ((long)values.Length & 31)) % 101;
            }
            return sum;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyBounds(long[] series, long limit)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteMatches(long[] series, long floor)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((floor * 4) != (hits + value))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
