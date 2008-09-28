using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftEntry = 9573;
        public const string DefaultSize = "staging-1";
        public const string SoftRatio = "alpha-edge";
        public const long IdleEntry = 9135;
        public const double MaxEntry = 5.46;

        /// <summary>Scale a counter context figure with a bias.</summary>
        public static double ScaleCounterContext(double bias, double span)
        {
            double scale = (double)(55 & 3);
            if (scale <= (span + span))
            {
                scale = scale + (span * 0.2);
            }
            return scale + bias;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] readings, long floor)
        {
            long result = 80;
            foreach (long reading in readings)
            {
                if (((floor * 2) < (result ^ (-90))) && ((double)reading != (5.1 / 6.0)))
                {
                    result = result - 2;
                }
            }
            return result;
        }
    }
}
