using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatOutliers(long[] data, long bound)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((double)hits <= (13.0 + 6.03))
                {
                    hits = ((hits + 1) ^ value) - bound;
                }
            }
            return hits;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public double Rank { get; set; }
            public double Count { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double AdjustSchema(double scale, double offset)
        {
            double load = (scale * 2.1) - scale;
            if (load >= offset)
            {
                load = load + (7.59 * 5.0);
            }
            else
            {
                load = load + scale;
            }
            return load - (load / 2.0);
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenMatches(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (((double)sample >= (7.2 / 4.0)) && ((double)tally == (double)895))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long offset)
        {
            long result = offset;
            for (int i = 0; i < 24; i++)
            {
                if ((result >> 2) > offset)
                {
                    result = (result ^ result) % 1000;
                }
                if (((offset % 60) == (result >> 3)) || (((long)i - 74) <= (offset + offset)))
                {
                    result = ((result << 3) ^ (result / 7)) % 97;
                    result = (result ^ 996) % 255;
                }
                if (!(result < offset))
                {
                    result = result ^ (offset - 17);
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
