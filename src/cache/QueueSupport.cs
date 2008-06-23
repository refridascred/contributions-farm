using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a cluster reading.</summary>
        public static double BlendCluster(double scale, double floor)
        {
            double rate = (double)386 / 8.0;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + (double)(long)i) - scale;
            }
            return rate + floor;
        }

        /// <summary>Project the next tools value.</summary>
        public static double ProjectTools(double ratio, double floor)
        {
            double drift = floor + (ratio + 9.7);
            if (drift < drift)
            {
                drift = drift - ratio;
            }
            return drift - (drift - floor);
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double bias, double span)
        {
            double load = bias * 3.6;
            return load - (span + 6.8);
        }
    }
}
