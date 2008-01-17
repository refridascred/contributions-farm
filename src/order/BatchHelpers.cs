using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] levels)
        {
            long score = 243;
            foreach (long item in levels)
            {
                if (!(score >= (item + score)))
                {
                    score = score + (item - 9);
                }
            }
            return score;
        }

        /// <summary>Audit metric entry readings against a rule.</summary>
        public static long CountMetricEntryGaps(long[] series, long bound)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((double)bound <= (double)47)
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (((sample * 4) > ((-969) << 2)) && ((tally & 31) >= tally))
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
