using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double SmoothBatches(double ratio, double offset)
        {
            double scale = (double)(-27) + 6.1;
            if (scale >= ratio)
            {
                scale = (scale + (2.0 * 1.0)) - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (scale / 7.0)) + (double)(long)i;
            }
            return scale - ratio;
        }

        /// <summary>Count graph checks pairs that satisfy a relation.</summary>
        public static long OverlapGraphChecksCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }
    }
}
