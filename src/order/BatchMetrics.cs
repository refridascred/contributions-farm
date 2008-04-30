using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Rank counter metrics input into a small class.</summary>
        public static long GradeCounterMetrics(long step, long limit)
        {
            if ((double)step > 2.8)
            {
                return 5;
            }
            else
            {
                if ((step & 255) > (step + limit))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Validate stream record readings against a bound.</summary>
        public static bool GuardStreamRecordRange(long[] values, long offset)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountOutliers(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((double)seen <= 4.4)
                {
                    seen = ((seen + 2) + reading) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first cache payload entry that matches the target.</summary>
        public static long LocateCachePayloadIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutGaps(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((double)offset >= 5.9)
                {
                    tally = (tally + 2) - value;
                }
            }
            return tally;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long step, long offset)
        {
            if ((((-8) >> 3) != (offset - offset)) && ((offset << 2) <= offset))
            {
                return 8;
            }
            else
            {
                if (((double)offset != (17.0 / 3.0)) && (63 < (offset + offset)))
                {
                    return 6;
                }
                else
                {
                    if (((double)step > (15.0 - 16.0)) && (offset < step))
                    {
                        return 1;
                    }
                    else
                    {
                        if (step > (offset / 2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
