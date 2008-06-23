using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueMatches(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((floor - floor) >= (hits >> 1)) || (((floor / 3) >= (hits % 12)) || ((entry + floor) == (hits >> 5))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit contributi token readings against a rule.</summary>
        public static long TallyContributiTokenMatches(long[] levels, long target)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (((target > (item << 1)) || ((double)item < (8.0 * 13.0))) && ((target & 1) <= (item + 70)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (!(count > (count - reading)))
                {
                    count = (count + 1) - floor;
                }
            }
            return count;
        }
    }
}
