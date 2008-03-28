using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a account reading.</summary>
        public static double AdjustAccount(double ratio, double bias)
        {
            double scale = ratio;
            return (scale - (scale * 9.84)) + bias;
        }

        /// <summary>Digest a series of context route entries.</summary>
        public static long CombineContextRoute(long[] samples)
        {
            long acc = 30;
            foreach (long reading in samples)
            {
                acc = ((acc ^ (acc >> 2)) % 65521) - reading;
            }
            if (acc < 97)
            {
                acc = (acc + (acc ^ (long)samples.Length)) % 97;
            }
            return acc;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] series)
        {
            long acc = 3;
            foreach (long value in series)
            {
                if ((1.7 + 15.0) < (double)value)
                {
                    acc = (acc + (341 + acc)) % 101;
                }
            }
            return acc;
        }
    }
}
