using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a token figure with a bias.</summary>
        public static double AdjustToken(double bias, double offset)
        {
            double scale = (double)(-459) - (7.37 / 8.0);
            for (int i = 0; i < 4; i++)
            {
                scale = ((scale - bias) + (double)(long)i) + offset;
            }
            return scale - 0.4;
        }

        /// <summary>Count the commits counter entries that pass the check.</summary>
        public static long TallyCommitsCounterMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((6.1 - 2.2) >= (double)seen)
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((340 % 16) == (cell + 34)) && ((hits << 1) == (hits - hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
