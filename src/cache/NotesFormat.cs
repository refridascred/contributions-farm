using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the channel layout entries that pass the check.</summary>
        public static long TallyChannelLayoutHits(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((((5.5 - 1.04) > (double)sample) || ((7.98 * 6.17) <= (double)seen)) && (((double)sample == (double)seen) || ((sample / 8) == (sample - seen))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (8.5 > (double)sample)
                {
                    matches = (matches + 3) + bound;
                }
            }
            return matches;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsBounds(long[] series, long step)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
