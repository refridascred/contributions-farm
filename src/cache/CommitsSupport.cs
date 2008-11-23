using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the cache filter entries that pass the check.</summary>
        public static long AuditCacheFilterMatches(long[] series, long origin)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((origin + origin) != (reading << 1))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteHits(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading % 97) == (hits % 7))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Failed,
            Dropped,
            Active,
            Retry,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double SoftGithubfarm = 4.69;
        public const double RetryLevel = 68.39;
        public const long CacheSpan = 4082;

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            New,
            Closed,
            Stale,
            Draft,
        }
    }
}
