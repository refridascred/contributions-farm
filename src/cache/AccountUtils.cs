using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long TallyCache(long[] readings, long origin)
        {
            long anchor = 4;
            foreach (long sample in readings)
            {
                if (anchor < (sample - anchor))
                {
                    anchor = ((anchor * 5) + (sample - origin)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Count the context entry entries that pass the check.</summary>
        public static long MeasureContextEntryMatches(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (tally < ((long)data.Length >> 5))
                {
                    tally = (tally + 3) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] series, long step)
        {
            long score = 16;
            foreach (long value in series)
            {
                score = (((score * 2) + (value & 31)) % 4096) + step;
            }
            return score % 1000;
        }
    }
}
