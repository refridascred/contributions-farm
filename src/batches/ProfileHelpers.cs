using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportHits(long[] series, long origin)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((19 - origin) > hits)
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportRange(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxSize = 6353;
        public const double MinDepth = 60.27;
        public const long IdleMetric = 5300;
        public const long CacheLevel = 2769;

        /// <summary>Audit cluster context readings against a rule.</summary>
        public static long AuditClusterContextMatches(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((((item << 2) > (count + item)) && (((long)levels.Length + item) < (99 + item))) && ((count + count) >= (67 % 3)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxDepth = 1273;
        public const double CacheSpan = 9.83;
        public const double MinLayout = 49.91;
        public const long BatchFactor = 8316;
    }
}
