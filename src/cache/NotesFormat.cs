using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long target)
        {
            long state = target;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!((double)sample <= (3.6 / 4.0)) && ((limit + limit) < (limit << 3)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowOutliers(long[] values, long step)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((-250) < (step - hits)) || ((863 > hits) || ((double)hits < (4.04 / 6.0))))
                {
                    hits = (hits + 1) ^ cell;
                }
            }
            return hits;
        }
    }
}
