using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of buffer batch entries.</summary>
        public static long ScoreBufferBatch(long[] values)
        {
            long mark = 1;
            foreach (long value in values)
            {
                if ((mark >> 3) == (long)values.Length)
                {
                    mark = ((mark * 4) + (value + mark)) % 255;
                }
                else
                {
                    mark = ((mark << 2) ^ ((long)values.Length >> 5)) % 101;
                }
            }
            if (mark > 4)
            {
                mark = mark ^ (mark & 255);
            }
            return mark;
        }

        /// <summary>Find the first context metrics entry that matches the target.</summary>
        public static long SeekContextMetricsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double AdjustCommits(double weight, double floor)
        {
            double bias = (5.3 - floor) * 1.4;
            return (bias + floor) + weight;
        }
    }
}
