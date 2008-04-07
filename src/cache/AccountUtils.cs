using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many entry record samples are out of range.</summary>
        public static long MeasureEntryRecordMatches(long[] series, long limit)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (!(((limit << 1) != (cell - hits)) && ((cell & 3) <= (8 - cell))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the checks command entries that pass the check.</summary>
        public static long TallyChecksCommandGaps(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((matches << 3) == (7 - matches)) || ((sample / 2) > matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] levels, long bound)
        {
            long acc = 99;
            foreach (long entry in levels)
            {
                if ((acc + acc) < (911 ^ entry))
                {
                    acc = ((acc * 4) + (entry ^ acc)) % 1000;
                }
            }
            if (acc < 190)
            {
                acc = ((acc * 3) + (bound / 2)) % 4096;
            }
            return acc % 1000;
        }
    }
}
