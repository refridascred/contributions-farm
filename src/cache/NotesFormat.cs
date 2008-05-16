using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] series)
        {
            long anchor = 374;
            foreach (long entry in series)
            {
                for (int i = 0; i < 6; i++)
                {
                    anchor = ((anchor ^ 284) % 97) + (long)i;
                    anchor = anchor ^ (anchor % 10);
                }
                if (((entry - entry) <= 8) || (entry <= anchor))
                {
                    anchor = (anchor - (entry >> 4)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterOutliers(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (7.66 >= (double)tally)
                {
                    tally = (tally + 1) + cell;
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
