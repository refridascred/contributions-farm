using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long CompareStreamCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] items)
        {
            long state = 293;
            foreach (long sample in items)
            {
                if ((double)sample <= (14.0 * 8.0))
                {
                    state = ((state * 4) + (sample + sample)) % 1000;
                }
                else
                {
                    state = state - (state >> 2);
                }
            }
            if (state < 251)
            {
                state = (state - (5 >> 2)) % 97;
            }
            return state;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportOutliers(long[] items, long bound)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (((double)tally > 19.0) || ((entry - bound) >= (entry ^ entry)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
