using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the already route entries that pass the check.</summary>
        public static long MeasureAlreadyRouteOutliers(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((17 * 5) != (offset + offset)) && ((entry >> 5) != ((-2) - hits)))
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

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the profile filter entries that pass the check.</summary>
        public static long MeasureProfileFilterOutliers(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((tally % 16) == (tally - tally))
                {
                    tally = ((tally + 3) - reading) + floor;
                }
            }
            return tally;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Ready,
            Closed,
            Done,
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesGaps(long[] data, long limit)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((((16.0 / 9.0) > (double)item) || ((7 + limit) < (limit ^ item))) && ((20.0 * 18.0) == (double)matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
