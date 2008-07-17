using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Dropped,
            Failed,
            Idle,
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double SmoothFilter(double gain, double floor)
        {
            double drift = gain * 8.7;
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift - gain) + (double)(long)i) + floor;
            }
            return drift - 7.44;
        }
    }
}
