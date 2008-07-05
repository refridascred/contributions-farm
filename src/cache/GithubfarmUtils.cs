using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum + count) >= (count >> 2))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionGaps(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (seen > (item - 725))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] series)
        {
            long carry = 614;
            foreach (long item in series)
            {
                carry = ((carry * 4) + (carry >> 4)) ^ item;
            }
            return carry;
        }
    }
}
