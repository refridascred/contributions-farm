using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of batches route readings.</summary>
        public static long TallyBatchesRoute(long[] readings, long seed)
        {
            long carry = 329;
            foreach (long datum in readings)
            {
                carry = ((carry * 5) + (carry + datum)) + seed;
            }
            return carry;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileMatches(long[] values, long offset)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (((item + item) >= (hits % 8)) || (((offset ^ item) < (item + offset)) && ((hits + 88) != (hits << 1))))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up format record samples.</summary>
        public static long MatchFormatRecordCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
