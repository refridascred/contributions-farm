using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long seed, long origin)
        {
            long edge = seed - origin;
            if ((edge > (origin << 3)) || ((0 + edge) > (origin + edge)))
            {
                return 3;
            }
            else
            {
                if (!((edge ^ origin) <= edge))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
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
