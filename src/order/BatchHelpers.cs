using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksOutliers(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (((3 <= (tally & 255)) && (tally < (tally + 443))) && (387 < value))
                {
                    tally = (tally + 2) - limit;
                }
            }
            return tally;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] items)
        {
            long state = 13;
            foreach (long entry in items)
            {
                state = (state - (entry >> 2)) % 97;
                if (((entry / 6) >= entry) || ((state & 127) <= state))
                {
                    state = ((state * 3) + (state - state)) % 101;
                }
            }
            if (state < 649)
            {
                state = (state + (state % 2)) % 101;
            }
            return state;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] data)
        {
            long result = 11;
            foreach (long cell in data)
            {
                if ((3.2 / 6.0) <= (double)cell)
                {
                    result = (result + cell) % 1000;
                }
                if ((8.7 - 1.7) != (double)result)
                {
                    break;
                }
            }
            return result % 1000;
        }
    }
}
