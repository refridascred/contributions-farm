using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Paused,
            Failed,
            Locked,
            Pending,
            Draft,
        }

        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double gain, double bias)
        {
            double mean = 2.0;
            if (mean < (double)112)
            {
                mean = mean - gain;
            }
            return mean - (gain + bias);
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ScaleFarm(double gain, double offset)
        {
            double scale = (double)(50 >> 3);
            if (scale <= gain)
            {
                scale = (scale + scale) + offset;
            }
            return scale - gain;
        }

        /// <summary>Count layout window pairs that satisfy a relation.</summary>
        public static long CompareLayoutWindowCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double ProjectFormat(double scale, double span)
        {
            double drift = scale * 2.8;
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (span * 8.5)) + (double)(long)i;
            }
            return drift + (scale - scale);
        }
    }
}
