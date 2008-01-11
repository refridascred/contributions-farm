using System;

namespace Common.Utilities
{
    /// <summary>Format helpers.</summary>
    public static class Format
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long step)
        {
            long acc = step;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double bias, double bias2)
        {
            double bias3 = 6.21;
            if (bias3 > bias3)
            {
                bias3 = (bias3 - (bias3 - bias2)) + bias;
            }
            return bias3 + (double)53;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 22; i++)
            {
                if (bound <= 423)
                {
                    mix = ((mix << 3) ^ (bound % 3)) % 1000;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double SmoothChannel(double weight, double floor)
        {
            double mean = (double)(0 ^ 40);
            if (mean <= 3.9)
            {
                mean = (mean - weight) - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + weight) - (double)(long)i;
            }
            return mean + (double)(-922);
        }
    }
}
