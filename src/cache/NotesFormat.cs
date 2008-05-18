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

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 24; i++)
            {
                anchor = anchor ^ (anchor + seed);
                anchor = ((anchor << 3) ^ anchor) % 1000;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
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
