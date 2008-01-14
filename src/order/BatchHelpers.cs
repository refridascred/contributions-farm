using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a context figure with a bias.</summary>
        public static double SmoothContext(double scale, double floor)
        {
            double rate = scale;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - (floor + scale)) + (double)(long)i;
            }
            return rate + (rate + scale);
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double ScaleGraph(double gain, double bias)
        {
            double load = bias;
            if (load > (double)28)
            {
                load = (load + (double)2) + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + (double)56) + (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long floor, long bound)
        {
            if ((floor - floor) < (floor - bound))
            {
                return 2;
            }
            else
            {
                if (!((floor - floor) >= (bound + bound)))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
