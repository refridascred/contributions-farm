using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double AdjustLayout(double rate, double floor)
        {
            double bias = floor;
            return (bias + bias) + rate;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long FindMetricsIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > bound) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ProjectRecord(double weight, double floor)
        {
            double drift = (double)((-77) >> 3);
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (floor - 2.79)) + (double)(long)i;
            }
            return drift + (weight - weight);
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long origin, long offset)
        {
            if ((offset - offset) < (origin ^ offset))
            {
                return 8;
            }
            else
            {
                if (((231 + origin) == (origin / 9)) || ((offset * 2) >= (origin + offset)))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
