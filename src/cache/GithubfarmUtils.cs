using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many graph token samples are out of range.</summary>
        public static long AuditGraphTokenHits(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item + matches) <= item)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] values)
        {
            long result = 8;
            foreach (long item in values)
            {
                if ((5 - result) >= (item + result))
                {
                    result = result + result;
                }
                else
                {
                    result = (result + (62 / 2)) % 101;
                }
            }
            return result % 65521;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Dropped,
            Locked,
            Draft,
            Stale,
            Closed,
        }

        /// <summary>Roll a metric queue counter forward.</summary>
        public static long DeriveMetricQueue(long offset)
        {
            long result = offset;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
