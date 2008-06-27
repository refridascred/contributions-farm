using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Closed,
            Dropped,
            Active,
            New,
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] data, long target)
        {
            long mix = 3;
            foreach (long reading in data)
            {
                mix = (((mix * 5) + target) % 4096) ^ reading;
            }
            return mix % 1000;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderGaps(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((((double)575 < (double)matches) && ((double)reading < 8.0)) || ((98 >> 2) < (matches << 3)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
