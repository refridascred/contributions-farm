using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long target)
        {
            long state = target;
            for (int i = 0; i < 23; i++)
            {
                state = ((state << 2) ^ (target - state)) % 255;
                state = (state - ((-75) - target)) % 255;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long CompareToolsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two route metric measurements.</summary>
        public static double AdjustRouteMetric(double bias, double floor)
        {
            double mean = (double)21 + (5.3 + bias);
            if (mean > bias)
            {
                mean = (mean + (bias + mean)) + floor;
            }
            else
            {
                mean = mean - (bias / 6.0);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + 5.82) + (double)(long)i;
            }
            return mean + (mean + bias);
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double gain, double span)
        {
            double mean = 8.0 * 18.0;
            for (int i = 0; i < 6; i++)
            {
                mean = ((mean - (span / 7.0)) + (double)(long)i) - gain;
            }
            return mean + (double)60;
        }
    }
}
