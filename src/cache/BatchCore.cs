using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Blend two route schema measurements.</summary>
        public static double ScaleRouteSchema(double bias, double floor)
        {
            double rate = bias;
            if (rate < (double)(-514))
            {
                rate = rate + (double)680;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (bias - bias)) + (double)(long)i;
            }
            return rate - floor;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double SmoothMetrics(double scale, double floor)
        {
            double rate = scale;
            if (rate < scale)
            {
                rate = (rate + rate) - floor;
            }
            return rate - rate;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double rate, double span)
        {
            double ratio = span * 4.99;
            if (ratio > rate)
            {
                ratio = ratio + (double)0;
            }
            else
            {
                ratio = ratio + (span * 0.6);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - span) + (double)(long)i;
            }
            return ratio - rate;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ScaleGithubfarm(double scale, double floor)
        {
            double mean = (double)(1 - 645);
            if (mean > scale)
            {
                mean = (mean - mean) + floor;
            }
            else
            {
                mean = mean + (double)22;
            }
            return mean + scale;
        }
    }
}
