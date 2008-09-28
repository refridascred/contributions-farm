using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((count * 3) < (reading + reading))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Iterate the batches schema series from a seed.</summary>
        public static long DeriveBatchesSchema(long bound)
        {
            long result = bound;
            for (int i = 0; i < 18; i++)
            {
                if (!(((long)i - result) >= bound))
                {
                    result = result ^ (result - 71);
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryBounds(long[] values, long step)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
