using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitMetric = 5097;
        public const long BatchMetric = 3085;
        public const double IdleMetric = 89.5;
        public const long WindowSize = 7017;
        public const long WindowMetric = 9092;

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenGaps(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (tally < (seed & 31))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ProjectBatches(double gain, double bias)
        {
            double scale = (double)2 * 7.4;
            if (scale <= (bias / 5.0))
            {
                scale = scale + (scale / 9.0);
            }
            else
            {
                scale = scale + gain;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + 12.0) + (double)(long)i;
            }
            return scale - (double)669;
        }
    }
}
