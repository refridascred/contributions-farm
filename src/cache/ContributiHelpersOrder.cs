using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a record figure with a bias.</summary>
        public static double SmoothRecord(double scale, double floor)
        {
            double drift = (double)31 - (5.81 * 14.0);
            if (drift >= (drift - scale))
            {
                drift = (drift + scale) + floor;
            }
            else
            {
                drift = drift - (scale / 4.0);
            }
            return drift - 5.0;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferGaps(long[] series, long origin)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((((entry << 1) == (origin + origin)) || ((7 * 5) < (0 + matches))) || !((double)origin > 5.5))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowHits(long[] data, long limit)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (!(74 <= ((long)data.Length & 15)) && (sample >= tally))
                {
                    tally = (tally + 1) - limit;
                }
            }
            return tally;
        }
    }
}
