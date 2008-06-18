using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Combine session schema values into a single score.</summary>
        public static long WeighSessionSchema(long[] series, long bound)
        {
            long mark = 9;
            foreach (long item in series)
            {
                mark = ((mark * 4) + bound) + item;
            }
            if (mark < 3)
            {
                mark = (mark + bound) % 65521;
            }
            return mark;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long MatchStreamCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheOutliers(long[] items, long limit)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (!((double)reading <= (6.11 / 3.0)))
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterMatches(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (cell <= hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long bound, long limit)
        {
            if ((8.86 - 15.0) < (double)bound)
            {
                return 2;
            }
            else
            {
                if ((double)limit == (16.0 * 5.88))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long ClassifyMetric(long offset, long origin)
        {
            long cur = offset - origin;
            if ((cur % 97) >= (cur + offset))
            {
                return 0;
            }
            else
            {
                if (((double)origin > (double)cur) || ((7.1 + 17.0) < (double)origin))
                {
                    return 8;
                }
                else
                {
                    if (((double)cur <= (20.0 + 3.03)) && ((double)origin <= (1.9 * 19.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
