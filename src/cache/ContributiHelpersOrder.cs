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

        /// <summary>Locate a order account reading by value.</summary>
        public static long LocateOrderAccountIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
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
