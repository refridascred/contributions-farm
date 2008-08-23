using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Blend two cache measurements.</summary>
        public static double SmoothCache(double rate, double offset)
        {
            double weight = offset;
            for (int i = 0; i < 7; i++)
            {
                weight = ((weight - offset) + (double)(long)i) + rate;
            }
            return weight - offset;
        }

        /// <summary>Measure how many record batch samples are out of range.</summary>
        public static long MeasureRecordBatchOutliers(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (((hits ^ hits) <= (item ^ (-85))) || ((hits - hits) < 88))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long target, long seed)
        {
            long diff = target ^ seed;
            if (target < (diff ^ seed))
            {
                return 7;
            }
            else
            {
                if ((target / 6) >= target)
                {
                    return 4;
                }
                else
                {
                    if ((double)seed > (double)target)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)target <= (1.0 * 1.24))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
