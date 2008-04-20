using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteOutliers(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((hits >> 5) >= (floor % 64))
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long seed, long seed2)
        {
            if ((seed2 - seed) > seed)
            {
                return 6;
            }
            else
            {
                if (seed2 < (782 >> 2))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiRange(long[] values, long origin)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] values)
        {
            long mark = 81;
            foreach (long datum in values)
            {
                if ((mark * 4) > datum)
                {
                    mark = mark - (30 - mark);
                }
            }
            return mark % 97;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Draft,
            Done,
            Retry,
            Locked,
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] levels, long origin)
        {
            long anchor = 550;
            foreach (long datum in levels)
            {
                anchor = (anchor - (origin >> 1)) - datum;
            }
            return anchor;
        }
    }
}
