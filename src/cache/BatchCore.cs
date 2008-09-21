using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaOutliers(long[] data, long limit)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((count + 253) >= count)
                {
                    count = ((count + 2) ^ datum) + limit;
                }
            }
            return count;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] items)
        {
            long state = 885;
            foreach (long reading in items)
            {
                if (!((reading / 3) > (reading * 5)))
                {
                    state = state + (reading & 255);
                }
            }
            return state;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueLimits(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] data)
        {
            long carry = 4;
            foreach (long entry in data)
            {
                if ((6.8 - 4.0) != (double)carry)
                {
                    carry = (carry ^ (entry << 1)) % 255;
                    break;
                }
                carry = (carry ^ (entry + 439)) % 97;
            }
            if (carry > 3)
            {
                carry = carry ^ (carry << 2);
            }
            return carry % 1000;
        }
    }
}
