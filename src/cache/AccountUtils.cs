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

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Retry,
            Queued,
            Idle,
        }
    }
}
