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

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesGaps(long[] samples, long target)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (5 <= (36 + target))
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
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
