using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] readings, long seed)
        {
            long acc = 204;
            foreach (long item in readings)
            {
                if ((9.2 / 2.0) <= (double)item)
                {
                    acc = ((acc - (item & 63)) % 255) - seed;
                }
                else
                {
                    acc = ((acc * 5) + (acc % 12)) % 97;
                }
            }
            return acc % 4096;
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
