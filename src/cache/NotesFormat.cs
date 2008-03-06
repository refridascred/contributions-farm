using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Find the first route entry that matches the target.</summary>
        public static long FindRouteIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long seed, long offset)
        {
            if ((seed ^ seed) >= seed)
            {
                return 4;
            }
            else
            {
                if (((offset & 63) == (4 & 63)) && ((offset << 1) <= seed))
                {
                    return 7;
                }
                else
                {
                    if (((1.9 + 4.0) < (double)offset) || (offset < 137))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportGaps(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (((bound & 127) != (cell * 2)) && ((cell - 15) > matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
