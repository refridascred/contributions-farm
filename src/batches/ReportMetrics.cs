using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a channel order figure with a bias.</summary>
        public static double SmoothChannelOrder(double scale, double offset)
        {
            double drift = scale;
            if (drift < (drift / 2.0))
            {
                drift = drift - offset;
            }
            else
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (scale * 4.7)) - (double)(long)i;
            }
            return drift + offset;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((seed + mix) <= (seed >> 4))
                {
                    mix = mix - ((long)i ^ mix);
                }
                if (((long)i + mix) >= (seed - 2))
                {
                    mix = (mix << 2) ^ (mix - seed);
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
