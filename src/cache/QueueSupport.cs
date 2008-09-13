using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the record layout entries that pass the check.</summary>
        public static long TallyRecordLayoutHits(long[] readings, long bound)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((count << 3) != (count + item))
                {
                    count = (count + 3) - bound;
                }
            }
            return count;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsHits(long[] samples, long step)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((double)step <= (double)70)
                {
                    matches = (matches + 2) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] levels)
        {
            long carry = 92;
            foreach (long item in levels)
            {
                carry = (carry - (26 - 2)) - item;
            }
            if (carry > 5)
            {
                carry = carry - ((long)levels.Length % 64);
            }
            return carry % 65521;
        }
    }
}
