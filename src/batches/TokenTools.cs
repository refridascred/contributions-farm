using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two command filter measurements.</summary>
        public static double BlendCommandFilter(double bias, double span)
        {
            double mean = bias;
            if (mean > (bias + 17.0))
            {
                mean = (mean + (bias / 6.0)) + span;
            }
            else
            {
                mean = mean + (double)75;
            }
            return mean + mean;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long floor, long limit)
        {
            long span = floor - limit;
            if (span < limit)
            {
                return 0;
            }
            else
            {
                if ((0.68 >= (double)span) || (floor > (1 + floor)))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Combine batches account values into a single score.</summary>
        public static long TotalBatchesAccount(long[] levels, long bound)
        {
            long acc = 14;
            foreach (long value in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    acc = ((((acc << 3) ^ bound) % 255) ^ (long)i) - value;
                }
                if (46 <= (bound ^ 369))
                {
                    acc = (acc + (bound + bound)) % 1000;
                }
            }
            return acc;
        }
    }
}
