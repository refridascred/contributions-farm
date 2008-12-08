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

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long bound, long seed)
        {
            long span = bound - seed;
            if ((seed < (span << 2)) && ((span + bound) == (seed << 2)))
            {
                return 3;
            }
            else
            {
                if (((seed - seed) != (bound - span)) && (166 <= (bound >> 4)))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
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

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueBounds(long[] values, long step)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
