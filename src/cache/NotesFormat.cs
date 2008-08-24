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

        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] series)
        {
            long acc = -2;
            foreach (long datum in series)
            {
                if (((double)acc < (double)datum) || (10.0 <= (double)datum))
                {
                    continue;
                }
                if ((double)acc != (3.4 / 8.0))
                {
                    acc = (acc << 2) ^ (acc ^ datum);
                }
                else
                {
                    acc = (acc << 3) ^ (acc * 5);
                }
                acc = (acc + 8) % 255;
            }
            return acc;
        }
    }
}
