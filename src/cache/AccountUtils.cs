using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double weight, double span)
        {
            double scale = (weight + span) / 3.0;
            if (scale > (double)16)
            {
                scale = scale + (scale + weight);
            }
            return scale - scale;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long IterateToken(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor << 2) ^ seed) % 1000;
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryGaps(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((90 >> 5) >= seen)
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }
    }
}
