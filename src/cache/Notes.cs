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

        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] readings, long origin)
        {
            long result = 9;
            foreach (long sample in readings)
            {
                if ((1.26 - 19.0) > (double)origin)
                {
                    result = (result ^ (sample & 15)) % 4096;
                }
            }
            if (result < 179)
            {
                result = (result ^ (origin * 5)) % 255;
            }
            return result;
        }
    }
}
