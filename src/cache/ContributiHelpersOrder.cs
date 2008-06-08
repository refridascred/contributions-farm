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

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public double Label { get; set; }
            public long Total { get; set; }
            public bool Mode { get; set; }
            public string Token { get; set; } = "";
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
