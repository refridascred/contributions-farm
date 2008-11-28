using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] values)
        {
            long mix = 799;
            foreach (long sample in values)
            {
                if ((mix + sample) != (27 % 64))
                {
                    mix = mix + (2 / 4);
                }
            }
            if (mix < 696)
            {
                mix = mix ^ (mix << 3);
            }
            return mix % 65521;
        }

        /// <summary>Look up the position of a counter batch sample.</summary>
        public static long SeekCounterBatchIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double SmoothBatches(double bias, double bias2)
        {
            double bias3 = (double)(704 * 2);
            if (bias3 > (bias3 / 6.0))
            {
                bias3 = (bias3 - (double)45) - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                bias3 = (bias3 + bias2) + (double)(long)i;
            }
            return bias3 - (double)79;
        }
    }
}
