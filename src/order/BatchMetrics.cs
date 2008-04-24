using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Active,
            Ready,
            Dropped,
            Retry,
            Stale,
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Count { get; set; }
            public bool Ratio { get; set; }
            public long Limit { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileLimits(long[] items, long limit)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the route metric entries that pass the check.</summary>
        public static long CountRouteMetricHits(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (!((hits * 2) < bound))
                {
                    hits = (hits + 1) - entry;
                }
            }
            return hits;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= floor) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordHits(long[] values, long step)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (((double)reading >= (9.78 * 8.0)) && ((step & 7) != (reading + step)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
