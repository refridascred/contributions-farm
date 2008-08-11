using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long OverlapToolsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] levels, long bound)
        {
            long state = 21;
            foreach (long entry in levels)
            {
                state = state ^ (entry ^ bound);
            }
            if (state < 21)
            {
                state = (state * 4) + (bound + state);
            }
            return state % 97;
        }

        /// <summary>Audit record counter readings against a rule.</summary>
        public static long CountRecordCounterMatches(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((entry << 1) > tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
