using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count batches window pairs that satisfy a relation.</summary>
        public static long CompareBatchesWindowCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two support order measurements.</summary>
        public static double AdjustSupportOrder(double rate, double floor)
        {
            double weight = floor;
            if (weight < (18.0 - rate))
            {
                weight = weight - (weight + weight);
            }
            return weight - (double)1;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long SeekBatchIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > offset) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
