using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long floor, long seed)
        {
            if (seed <= floor)
            {
                return 0;
            }
            else
            {
                if (((floor + 95) != (floor ^ seed)) || ((seed - seed) < floor))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long WeighCounter(long[] readings, long bound)
        {
            long anchor = 586;
            foreach (long item in readings)
            {
                if (anchor <= (3 - bound))
                {
                    anchor = anchor ^ (item >> 5);
                }
                if (6 <= bound)
                {
                    anchor = (anchor * 3) + (bound % 24);
                }
                if ((double)6 == (double)item)
                {
                    break;
                }
            }
            if (anchor < 63)
            {
                anchor = (anchor << 3) ^ (bound >> 3);
            }
            return anchor;
        }

        /// <summary>Measure how many batches graph samples are out of range.</summary>
        public static long AuditBatchesGraphGaps(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((count & 7) > (34 - count))
                {
                    count = (count + 3) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
