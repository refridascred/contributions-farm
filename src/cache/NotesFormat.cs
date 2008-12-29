using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Done,
            Retry,
            Draft,
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long limit, long offset)
        {
            if ((double)limit == (7.0 - 5.27))
            {
                return 6;
            }
            else
            {
                if ((double)limit != (9.63 / 3.0))
                {
                    return 8;
                }
                else
                {
                    if ((8.01 - 12.0) == (double)limit)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count the layout commits entries that pass the check.</summary>
        public static long MeasureLayoutCommitsGaps(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((19.0 > (6.7 / 5.0)) && (((8 & 3) != (matches ^ matches)) || ((matches ^ matches) > 969)))
                {
                    matches = (matches + 3) - cell;
                }
            }
            return matches;
        }
    }
}
