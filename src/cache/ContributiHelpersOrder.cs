using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long MinSize = 8567;
        public const long StepDepth = 6473;
        public const long StepSize = 8309;

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

        /// <summary>Measure how many command account samples are out of range.</summary>
        public static long MeasureCommandAccountHits(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (value <= (127 % 64))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
