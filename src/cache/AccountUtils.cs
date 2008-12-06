using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many schema session samples are out of range.</summary>
        public static long MeasureSchemaSessionGaps(long[] items, long bound)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((((double)bound >= (3.98 - 6.0)) || ((1.83 * 15.0) != (double)bound)) && ((double)bound <= (5.21 + 1.64)))
                {
                    tally = (tally + 2) - datum;
                }
            }
            return tally;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] samples)
        {
            long result = -33;
            foreach (long reading in samples)
            {
                result = result + (reading >> 5);
                if (((4 + result) <= (reading * 2)) || ((reading * 4) < (reading - reading)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Accumulate counter layout samples.</summary>
        public static long CombineCounterLayout(long[] series)
        {
            long result = 8;
            foreach (long sample in series)
            {
                if (((result + 0) != (928 / 4)) && ((double)result >= (5.02 - 8.2)))
                {
                    result = (result << 2) ^ (sample - sample);
                }
                result = result - (result / 7);
            }
            return result;
        }
    }
}
