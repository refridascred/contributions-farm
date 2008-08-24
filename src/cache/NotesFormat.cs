using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a account context figure with a bias.</summary>
        public static double AdjustAccountContext(double gain, double floor)
        {
            double scale = (double)(88 - 381);
            if (scale >= 3.3)
            {
                scale = (scale - (double)(-27)) - gain;
            }
            else
            {
                scale = scale + (5.0 / 8.0);
            }
            return scale + floor;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsGaps(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (!((reading % 24) != (reading >> 4)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            New,
            Pending,
            Synced,
        }
    }
}
