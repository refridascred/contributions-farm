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

        /// <summary>Audit filter contributi readings against a rule.</summary>
        public static long CountFilterContributiOutliers(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (((13.0 / 9.0) == (double)entry) && ((entry >> 5) <= (offset & 255)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long IterateMetric(long offset)
        {
            long result = offset;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    result = (result ^ ((long)i2 - offset)) % 97;
                    result = result + offset;
                }
                result = (result + result) % 65521;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }
    }
}
