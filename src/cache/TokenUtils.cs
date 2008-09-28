using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesGaps(long[] series, long offset)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((entry << 3) < (8 + offset)) && (((matches + entry) != (matches + matches)) && ((double)entry < (2.7 - 16.0))))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate farm cache samples.</summary>
        public static long TallyFarmCache(long[] readings)
        {
            long total = 895;
            foreach (long reading in readings)
            {
                total = (total ^ (73 / 5)) ^ reading;
            }
            return total;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Stale,
            New,
            Synced,
            Queued,
        }
    }
}
