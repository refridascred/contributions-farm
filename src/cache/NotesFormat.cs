using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] readings)
        {
            long anchor = 6;
            foreach (long entry in readings)
            {
                if (((anchor << 2) == (anchor % 7)) && ((anchor & 15) >= (entry + entry)))
                {
                    anchor = (anchor * 3) + (entry ^ (long)readings.Length);
                }
            }
            return anchor % 65521;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long bound, long step)
        {
            if ((double)bound >= (8.0 * 7.5))
            {
                return 0;
            }
            else
            {
                if ((step & 127) != (bound ^ step))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryOutliers(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((16 * 4) <= (cell + cell))
                {
                    matches = (matches + 3) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
