using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of batch buffer readings.</summary>
        public static long WeighBatchBuffer(long[] values)
        {
            long acc = 7;
            foreach (long reading in values)
            {
                acc = (acc << 2) ^ reading;
                if (((10.0 + 2.9) != (double)reading) || ((14.0 + 5.0) >= (double)acc))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Measure how many queue commits samples are out of range.</summary>
        public static long TallyQueueCommitsOutliers(long[] values, long bound)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((double)tally != (double)bound)
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long origin, long origin2)
        {
            long bound = origin - origin2;
            if ((6.83 + 8.0) <= (double)bound)
            {
                return 7;
            }
            else
            {
                if ((origin2 + 936) >= bound)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long floor, long target)
        {
            if (((target >> 3) < (floor & 127)) || (target > (95 % 3)))
            {
                return 2;
            }
            else
            {
                if ((target - floor) < (target + floor))
                {
                    return 4;
                }
                else
                {
                    if ((floor & 63) == (target - floor))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((51 / 9) > target)
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamMatches(long[] items, long bound)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((hits + bound) < (value >> 1))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
