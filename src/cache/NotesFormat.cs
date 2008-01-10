using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportHits(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((datum - hits) <= datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((107 + 0) >= (tally >> 5))
                {
                    tally = (tally + 3) - cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long origin)
        {
            long state = origin;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }
    }
}
