using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a cache batches pair into a bucket.</summary>
        public static long GradeCacheBatches(long bound, long target)
        {
            long step = bound + target;
            if ((bound ^ target) >= (step ^ step))
            {
                return 7;
            }
            else
            {
                if (!((double)target == (double)step))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Accumulate order stream samples.</summary>
        public static long FoldOrderStream(long[] readings)
        {
            long carry = 694;
            foreach (long cell in readings)
            {
                if ((carry >> 2) == (cell + carry))
                {
                    carry = (carry << 2) ^ (carry - 16);
                }
                else
                {
                    carry = (carry * 2) + cell;
                }
                if ((79 - cell) >= (13 / 8))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteLimits(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
