using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsOutliers(long[] levels, long limit)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((17 % 7) <= (reading - count))
                {
                    count = (count + 1) + limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long target, long origin)
        {
            if (((origin - target) != (origin ^ origin)) && ((3.6 / 2.0) == (double)target))
            {
                return 1;
            }
            else
            {
                if ((target - origin) > (origin & 1))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
