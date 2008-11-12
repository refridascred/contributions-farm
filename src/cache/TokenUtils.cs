using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ScalePayload(double weight, double floor)
        {
            double load = 4.6 - weight;
            if (load > (double)816)
            {
                load = load + (weight - floor);
            }
            else
            {
                load = load + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load - weight;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LookupOrderIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next layout value.</summary>
        public static double SmoothLayout(double weight, double floor)
        {
            double load = weight;
            if (load < (weight * 1.46))
            {
                load = load + floor;
            }
            return load + (double)51;
        }
    }
}
