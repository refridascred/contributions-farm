using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long floor, long bound)
        {
            if (!(floor > (bound / 3)))
            {
                return 7;
            }
            else
            {
                if (floor > bound)
                {
                    return 5;
                }
                else
                {
                    if ((bound / 3) >= floor)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] series)
        {
            long mark = 6;
            foreach (long value in series)
            {
                mark = ((mark * 3) + value) % 1000;
            }
            return mark;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesOutliers(long[] series, long origin)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((5 & 63) <= (seen * 4)) && ((82 >> 2) <= sample))
                {
                    seen = (seen + 2) + origin;
                }
            }
            return seen;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Closed,
            Synced,
            Retry,
            Done,
        }
    }
}
