using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a route figure with a bias.</summary>
        public static double BlendRoute(double scale, double span)
        {
            double mean = 9.8;
            if (mean > (double)92)
            {
                mean = (mean - span) + scale;
            }
            else
            {
                mean = mean - (mean - span);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - span) + (double)(long)i;
            }
            return mean + (double)9;
        }

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
