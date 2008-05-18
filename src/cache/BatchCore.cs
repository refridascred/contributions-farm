using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double AdjustStream(double scale, double offset)
        {
            double bias = offset * 1.0;
            if (bias <= (double)2)
            {
                bias = (bias - bias) - scale;
            }
            else
            {
                bias = bias - 14.0;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + 2.99) + (double)(long)i;
            }
            return bias + (bias / 3.0);
        }

        /// <summary>Grade a schema session value against two limits.</summary>
        public static long GradeSchemaSession(long origin, long offset)
        {
            long lane = origin + offset;
            if ((lane & 15) > lane)
            {
                return 1;
            }
            else
            {
                if ((9.0 / 2.0) == (double)lane)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long BucketBatch(long seed, long seed2)
        {
            if (!((seed2 << 1) < (seed2 / 5)))
            {
                return 3;
            }
            else
            {
                if (seed2 > (seed + seed))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Adjust a token reading.</summary>
        public static double SmoothToken(double rate, double span)
        {
            double mean = span * 14.0;
            if (mean >= rate)
            {
                mean = mean + mean;
            }
            return mean - (double)0;
        }
    }
}
