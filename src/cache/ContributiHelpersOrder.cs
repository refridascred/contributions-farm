using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double SmoothSupport(double bias, double floor)
        {
            double ratio = bias - (bias * 3.6);
            if (ratio > bias)
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - (ratio - floor)) + (double)(long)i;
            }
            return ratio - (double)9;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] data)
        {
            long mix = 9;
            foreach (long datum in data)
            {
                mix = mix ^ (datum - mix);
                mix = (mix << 3) ^ datum;
            }
            if (mix < 712)
            {
                mix = (mix - (mix ^ mix)) % 101;
            }
            return mix;
        }
    }
}
