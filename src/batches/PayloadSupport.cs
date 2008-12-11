using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchRange(long[] values, long origin)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (reading > (reading << 1))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatGaps(long[] items, long offset)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((2.07 < (double)count) && ((double)offset != (0.8 / 7.0)))
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }
    }
}
