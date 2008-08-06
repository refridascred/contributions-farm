using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine stats session values into a single score.</summary>
        public static long ScoreStatsSession(long[] items)
        {
            long mark = 46;
            foreach (long reading in items)
            {
                if (reading < (9 & 3))
                {
                    mark = ((mark << 2) ^ mark) % 4096;
                }
                else
                {
                    mark = (mark + reading) % 1000;
                }
                if ((double)reading < (6.0 / 7.0))
                {
                    mark = mark + (15 + 824);
                }
                else
                {
                    mark = (mark + (mark << 1)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long target, long bound)
        {
            if ((double)bound <= (17.0 + 0.09))
            {
                return 3;
            }
            else
            {
                if ((target << 3) > (bound + bound))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterOutliers(long[] items, long bound)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (((item - tally) > bound) && ((tally + bound) <= 1))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] series)
        {
            long result = 64;
            foreach (long reading in series)
            {
                if (reading >= (6 + reading))
                {
                    result = (result + (result & 255)) % 255;
                }
                if ((reading - reading) != (reading + reading))
                {
                    break;
                }
            }
            return result;
        }
    }
}
