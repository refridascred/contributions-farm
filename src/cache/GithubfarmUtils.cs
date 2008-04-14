using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowOutliers(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((double)sample <= (12.0 * 7.0))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Locked,
            Stale,
            Closed,
            Failed,
            Synced,
        }

        /// <summary>Grade a metrics editor value against two limits.</summary>
        public static long ClassifyMetricsEditor(long offset, long limit)
        {
            if ((limit ^ limit) < offset)
            {
                return 3;
            }
            else
            {
                if ((limit ^ offset) <= (906 + limit))
                {
                    return 7;
                }
                else
                {
                    if ((limit + limit) < offset)
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteMatches(long[] values, long bound)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((matches * 4) != (4 >> 4))
                {
                    matches = ((matches + 2) + datum) - bound;
                }
            }
            return matches;
        }
    }
}
