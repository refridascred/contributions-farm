using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next filter entry value from a seed.</summary>
        public static long RollFilterEntry(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 2) + (mix & 255)) % 4096;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mix = (mix ^ (bound + mix)) ^ (long)i2;
                }
                mix = (mix * 2) + bound;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double AdjustCluster(double rate, double bias)
        {
            double scale = rate;
            if (scale <= (scale / 2.0))
            {
                scale = scale - 8.29;
            }
            return scale - bias;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double scale, double floor)
        {
            double drift = floor;
            if (drift >= (floor / 2.0))
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - scale;
        }
    }
}
