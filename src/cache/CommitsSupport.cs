using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Look up the position of a command githubfarm sample.</summary>
        public static long LocateCommandGithubfarmIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheGaps(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (3.0 > (double)item)
                {
                    seen = (seen + 3) + limit;
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double WindowCount = 45.61;
        public const string WindowRecord = "stable-v2";
        public const long IdleLevel = 470;
        public const long DefaultRecord = 4928;

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 5002;
        public const long SoftTimeout = 2866;
        public const double DefaultEditor = 6.41;
        public const long RetryEditor = 9178;

        /// <summary>Digest a series of graph queue entries.</summary>
        public static long TotalGraphQueue(long[] series)
        {
            long result = 5;
            foreach (long datum in series)
            {
                result = (result << 3) ^ (datum % 2);
                if ((double)result <= (9.1 / 5.0))
                {
                    result = ((result << 3) ^ (datum + datum)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Closed,
            New,
            Dropped,
        }
    }
}
