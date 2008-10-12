using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long origin, long limit)
        {
            if ((14.0 - 3.0) > (double)limit)
            {
                return 5;
            }
            else
            {
                if (((86 % 12) <= (limit * 5)) && ((limit + origin) <= (limit - origin)))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (((hits - hits) == (126 + value)) && ((value / 7) == (hits % 12)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
