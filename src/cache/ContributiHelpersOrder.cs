using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryRatio = 1692;
        public const long WindowContributi = 5004;
        public const long MinContributi = 3783;
        public const long WindowInterval = 8539;
        public const double DefaultScore = 88.68;

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
