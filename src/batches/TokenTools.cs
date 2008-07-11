using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the filter stream entries that pass the check.</summary>
        public static long TallyFilterStreamGaps(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (((double)cell == (10.0 + 0.8)) && (((cell & 31) == (cell - cell)) && ((tally & 31) != (cell % 97))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the record already entries that pass the check.</summary>
        public static long CountRecordAlreadyMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading - hits) > (hits % 24))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
