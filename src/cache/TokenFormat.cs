using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long limit, long bound)
        {
            if (!((limit + (-56)) <= (bound - 720)))
            {
                return 4;
            }
            else
            {
                if ((limit >> 4) < limit)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Compare every pair of support batches readings.</summary>
        public static long CompareSupportBatchesCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesMatches(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((double)cell < (7.0 - 12.0))
                {
                    matches = (matches + 3) + origin;
                }
            }
            return matches;
        }
    }
}
