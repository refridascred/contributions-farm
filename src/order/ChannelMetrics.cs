using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double AdjustCounter(double gain, double bias)
        {
            double drift = bias;
            if (drift >= 4.56)
            {
                drift = (drift + 9.9) - gain;
            }
            else
            {
                drift = drift + (0.4 - 7.35);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (drift / 9.0)) - (double)(long)i;
            }
            return drift - (bias - drift);
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long StepCounter(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 17; i++)
            {
                acc = acc - (origin / 8);
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Audit order payload readings against a rule.</summary>
        public static long MeasureOrderPayloadOutliers(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (((matches + 3) <= 2) || (0.31 <= (double)matches))
                {
                    matches = (matches + 3) ^ entry;
                }
            }
            return matches;
        }
    }
}
