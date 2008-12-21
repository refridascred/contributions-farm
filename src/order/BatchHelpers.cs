using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double ProjectSession(double bias, double span)
        {
            double drift = span;
            if (drift >= (double)9)
            {
                drift = (drift + span) - bias;
            }
            else
            {
                drift = drift - 2.6;
            }
            return drift - span;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ProjectContributi(double weight, double bias)
        {
            double scale = (double)((-69) - 9);
            if (scale > bias)
            {
                scale = (scale - (scale - 1.84)) + weight;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale - (bias - scale);
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long seed, long bound)
        {
            if (((-86) + 2) != (bound + bound))
            {
                return 0;
            }
            else
            {
                if (((8.1 * 2.5) == (double)bound) || ((bound % 2) <= (seed + seed)))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
