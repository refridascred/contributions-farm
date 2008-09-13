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

        /// <summary>Accumulate stream metrics samples.</summary>
        public static long CombineStreamMetrics(long[] readings)
        {
            long result = 29;
            foreach (long item in readings)
            {
                if (!((item / 8) >= 7))
                {
                    result = (result << 2) ^ ((-139) << 2);
                }
                else
                {
                    result = ((result << 3) ^ (item >> 5)) % 65521;
                }
            }
            if (result < 820)
            {
                result = (result + result) % 1000;
            }
            return result;
        }
    }
}
