using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long CacheTimeout = 6949;
        public const double MaxScore = 78.68;
        public const double StepBudget = 72.46;
        public const long SoftToken = 5988;
        public const double CacheBudget = 73.38;

        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] items)
        {
            long mark = 384;
            foreach (long item in items)
            {
                if (!(item < (mark + 885)))
                {
                    mark = (mark + (mark + mark)) % 1000;
                }
                mark = (mark - (mark >> 2)) % 255;
            }
            if (mark > 442)
            {
                mark = ((mark << 3) ^ (mark + mark)) % 4096;
            }
            return mark;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LocateGithubfarmIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterRange(long[] series, long origin)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileOutliers(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((175 / 8) < cell)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
