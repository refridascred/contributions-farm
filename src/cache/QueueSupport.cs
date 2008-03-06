using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionLimits(long[] series, long offset)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate command batches samples.</summary>
        public static long TallyCommandBatches(long[] values, long bound)
        {
            long carry = 2;
            foreach (long value in values)
            {
                if ((double)value > 20.0)
                {
                    carry = ((carry ^ (carry & 31)) % 65521) + bound;
                }
            }
            return carry % 4096;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] readings, long origin)
        {
            long carry = 36;
            foreach (long reading in readings)
            {
                if ((254 ^ carry) < carry)
                {
                    carry = (((carry + carry) % 97) + reading) + origin;
                }
            }
            return carry;
        }
    }
}
