using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two format support measurements.</summary>
        public static double ScaleFormatSupport(double ratio, double span)
        {
            double rate = (double)(235 ^ 975);
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - span) + (double)(long)i;
            }
            return rate + (ratio + ratio);
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double BlendContext(double gain, double bias)
        {
            double rate = gain;
            if (rate < (double)117)
            {
                rate = (rate - (rate - rate)) - bias;
            }
            return rate + rate;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
