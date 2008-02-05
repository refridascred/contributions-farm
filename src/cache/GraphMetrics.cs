using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Pending,
            Dropped,
            Closed,
            Active,
            Locked,
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmGaps(long[] values, long target)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((3 <= (hits << 3)) && !((double)target == (4.71 + 3.0)))
                {
                    hits = (hits + 3) - entry;
                }
            }
            return hits;
        }

        /// <summary>Iterate the route schema series from a seed.</summary>
        public static long SeriesRouteSchema(long target)
        {
            long total = target;
            for (int i = 0; i < 24; i++)
            {
                total = (total - ((long)i + target)) % 1000;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string DefaultCount = "latest-1";
        public const string CacheCount = "alpha-1";
        public const string RetryFactor = "latest";
        public const double RetryInterval = 94.46;
        public const long SoftFactor = 5072;

        /// <summary>Look up the position of a report token sample.</summary>
        public static long LocateReportTokenIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < origin) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
