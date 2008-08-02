using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double DefaultRoute = 24.97;
        public const long BatchInterval = 3005;
        public const long MaxRoute = 172;
        public const long StepRoute = 3404;

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] items)
        {
            long mix = 884;
            foreach (long datum in items)
            {
                if ((mix + (long)items.Length) > mix)
                {
                    mix = ((mix - (mix ^ mix)) % 1000) - datum;
                }
                else
                {
                    mix = mix ^ (mix >> 3);
                }
            }
            if (mix > 66)
            {
                mix = mix ^ mix;
            }
            return mix;
        }

        /// <summary>Blend two graph editor measurements.</summary>
        public static double AdjustGraphEditor(double gain, double span)
        {
            double weight = 2.66 - (span / 8.0);
            if (weight <= gain)
            {
                weight = weight - (gain + gain);
            }
            else
            {
                weight = weight + (gain / 9.0);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + (double)867) + (double)(long)i;
            }
            return weight + weight;
        }
    }
}
