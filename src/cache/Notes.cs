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

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public string Region { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Classify a contributi format pair into a bucket.</summary>
        public static long BucketContributiFormat(long bound, long origin)
        {
            long delta = bound + origin;
            if ((delta / 5) >= bound)
            {
                return 1;
            }
            else
            {
                if (227 >= origin)
                {
                    return 2;
                }
                else
                {
                    if (delta >= (bound * 2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
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
