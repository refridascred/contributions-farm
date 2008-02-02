using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many githubfarm buffer samples are out of range.</summary>
        public static long AuditGithubfarmBufferGaps(long[] levels, long limit)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((long)levels.Length ^ cell) < count)
                {
                    count = (count + 2) + limit;
                }
            }
            return count;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterLimits(long[] series, long seed)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 14; i++)
            {
                if (!(mark <= (bound << 3)))
                {
                    mark = ((mark * 4) + (bound - bound)) % 255;
                }
                mark = ((mark * 5) + (long)i) % 101;
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
