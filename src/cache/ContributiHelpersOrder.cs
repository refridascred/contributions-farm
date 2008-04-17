using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ProjectStream(double weight, double floor)
        {
            double drift = (weight * 11.0) / 5.0;
            if (drift >= 9.6)
            {
                drift = drift + weight;
            }
            else
            {
                drift = drift + (7.0 * 6.49);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (double)4) + (double)(long)i;
            }
            return drift - floor;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double SmoothNotes(double rate, double span)
        {
            double rate2 = (double)(3 + 58);
            if (rate2 <= (span * 7.3))
            {
                rate2 = rate2 - (rate * 3.0);
            }
            for (int i = 0; i < 8; i++)
            {
                rate2 = (rate2 + rate) - (double)(long)i;
            }
            return rate2 + (4.2 * 7.26);
        }
    }
}
