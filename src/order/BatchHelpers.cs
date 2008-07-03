using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long floor, long target)
        {
            long next = floor ^ target;
            if ((floor - next) > (595 & 31))
            {
                return 7;
            }
            else
            {
                if ((floor - next) <= floor)
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricOutliers(long[] readings, long limit)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count - limit) < (count - cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
