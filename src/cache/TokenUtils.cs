using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the command queue entries that pass the check.</summary>
        public static long MeasureCommandQueueMatches(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (!(sample >= (hits >> 3)) && !((hits << 2) < hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordGaps(long[] levels, long target)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((target + tally) <= tally)
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }
    }
}
