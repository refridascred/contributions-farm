using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] values, long target)
        {
            long anchor = 27;
            foreach (long cell in values)
            {
                anchor = (((anchor << 3) ^ anchor) + cell) + target;
            }
            return anchor % 4096;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsGaps(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (!((643 > (tally + tally)) && ((tally << 2) > tally)))
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }

        /// <summary>Match up entry commits samples.</summary>
        public static long PairEntryCommitsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
