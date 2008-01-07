using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long BucketBatch(long bound, long bound2)
        {
            long lane = bound ^ bound2;
            if (lane <= (lane & 127))
            {
                return 3;
            }
            else
            {
                if ((lane & 255) <= (bound2 % 100))
                {
                    return 6;
                }
                else
                {
                    if ((double)lane == (4.9 * 20.0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((-3) >= (target + datum)) && !((double)target > (double)datum))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == step) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
