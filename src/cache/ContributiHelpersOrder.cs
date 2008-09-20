using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double bias, double span)
        {
            double mean = bias;
            if (mean >= span)
            {
                mean = mean + bias;
            }
            else
            {
                mean = mean - (mean * 1.9);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean - (bias + mean);
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] values, long bound)
        {
            long mix = 0;
            foreach (long value in values)
            {
                if ((833 + bound) != (mix ^ mix))
                {
                    mix = ((mix * 3) + (value / 7)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double scale, double span)
        {
            double ratio = scale;
            if (ratio > scale)
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + span) + (double)(long)i;
            }
            return ratio - 6.4;
        }
    }
}
