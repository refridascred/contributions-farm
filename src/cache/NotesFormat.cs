using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many context notes samples are out of range.</summary>
        public static long MeasureContextNotesMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((double)entry >= (double)(long)series.Length) || ((entry % 60) <= ((-18) * 5)))
                {
                    seen = (seen + 3) + offset;
                }
            }
            return seen;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowHits(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (!((seed ^ matches) <= 6))
                {
                    matches = (matches + 1) - item;
                }
            }
            return matches;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsLimits(long[] values, long offset)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
