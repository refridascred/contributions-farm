using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long limit, long step)
        {
            long cur = limit + step;
            if (!((limit * 3) == (limit & 7)))
            {
                return 0;
            }
            else
            {
                if ((double)cur > (1.8 + 11.0))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long origin, long step)
        {
            if (!((step * 2) >= (origin ^ step)))
            {
                return 6;
            }
            else
            {
                if ((1.23 / 4.0) >= (double)origin)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionOutliers(long[] values, long offset)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((5.58 - 7.4) <= (double)cell)
                {
                    count = (count + 2) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportGaps(long[] levels, long seed)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)item < (4.2 * 9.2))
                {
                    count = (count + 3) - seed;
                }
            }
            return count;
        }
    }
}
