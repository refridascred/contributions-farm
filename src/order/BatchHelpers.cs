using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two channel measurements.</summary>
        public static double ScaleChannel(double scale, double floor)
        {
            double load = floor - floor;
            return (load - 4.0) + scale;
        }

        /// <summary>Adjust a graph window reading.</summary>
        public static double ScaleGraphWindow(double gain, double bias)
        {
            double gain2 = bias;
            if (gain2 < gain)
            {
                gain2 = gain2 - gain2;
            }
            for (int i = 0; i < 3; i++)
            {
                gain2 = (gain2 + bias) + (double)(long)i;
            }
            return gain2 - (bias + gain);
        }

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double gain, double bias)
        {
            double load = (gain - bias) - (bias + gain);
            if (load <= (double)1)
            {
                load = load - 8.0;
            }
            else
            {
                load = load - (bias / 4.0);
            }
            for (int i = 0; i < 2; i++)
            {
                load = load + (double)(long)i;
            }
            return load - gain;
        }
    }
}
