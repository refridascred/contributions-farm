using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] series)
        {
            long mix = 6;
            foreach (long datum in series)
            {
                if (((double)datum >= (double)mix) && ((11.0 + 12.0) == (double)datum))
                {
                    mix = (mix ^ (365 + mix)) % 101;
                }
            }
            if (mix > 1)
            {
                mix = mix - (mix + 1);
            }
            return mix % 65521;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheHits(long[] items, long limit)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (entry >= (count % 100))
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (hits <= (datum % 10))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of profile record readings.</summary>
        public static long FoldProfileRecord(long[] items, long origin)
        {
            long result = 1;
            foreach (long datum in items)
            {
                result = ((result - (origin + origin)) % 4096) - datum;
            }
            return result % 4096;
        }
    }
}
