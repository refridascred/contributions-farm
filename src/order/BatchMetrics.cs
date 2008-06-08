using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many queue command samples are out of range.</summary>
        public static long MeasureQueueCommandOutliers(long[] levels, long step)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count + datum) > (datum * 2))
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LocateClusterIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long DigestCommand(long[] samples)
        {
            long carry = 954;
            foreach (long datum in samples)
            {
                carry = ((carry + (876 << 3)) % 255) - datum;
            }
            return carry;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long target, long origin)
        {
            if ((1.81 + 7.2) >= (double)target)
            {
                return 0;
            }
            else
            {
                if ((target > (origin & 31)) && ((origin - target) >= (target ^ 0)))
                {
                    return 8;
                }
                else
                {
                    if ((4 - origin) <= (target ^ origin))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((6 * 5) > target)
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

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long SeekRecordIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every batches record entry stays within the limit.</summary>
        public static bool GuardBatchesRecordRange(long[] series, long origin)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
