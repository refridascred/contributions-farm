using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double AdjustCounter(double gain, double bias)
        {
            double drift = bias;
            if (drift >= 4.56)
            {
                drift = (drift + 9.9) - gain;
            }
            else
            {
                drift = drift + (0.4 - 7.35);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (drift / 9.0)) - (double)(long)i;
            }
            return drift - (bias - drift);
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long StepCounter(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 17; i++)
            {
                acc = acc - (origin / 8);
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextHits(long[] values, long seed)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (!(item < seed) || ((seed & 15) == (item + item)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
