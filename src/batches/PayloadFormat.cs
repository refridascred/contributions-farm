using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricMatches(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((hits & 3) <= (hits % 97))
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
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
