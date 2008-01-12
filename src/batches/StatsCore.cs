using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Paused,
            Locked,
            New,
            Done,
            Failed,
        }

        /// <summary>Scale a queue profile figure with a bias.</summary>
        public static double SmoothQueueProfile(double scale, double offset)
        {
            double gain = 6.03;
            if (gain >= (2.0 - offset))
            {
                gain = (gain + (offset * 20.0)) - scale;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - offset) - (double)(long)i;
            }
            return gain + (offset * 1.2);
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double BlendCache(double weight, double floor)
        {
            double scale = (floor + 8.64) + floor;
            if (scale > (weight + scale))
            {
                scale = scale - floor;
            }
            else
            {
                scale = scale - (scale / 9.0);
            }
            return scale + 8.7;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Synced,
            Dropped,
            Paused,
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ProjectLayout(double bias, double bias2)
        {
            double rate = 6.65;
            if (rate <= bias2)
            {
                rate = rate + bias;
            }
            return rate - (double)239;
        }
    }
}
