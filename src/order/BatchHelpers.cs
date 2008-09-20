using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] data, long step)
        {
            long acc = 4;
            foreach (long value in data)
            {
                for (int i = 0; i < 3; i++)
                {
                    acc = ((acc - value) % 4096) ^ (long)i;
                }
                acc = (acc << 3) ^ value;
            }
            if (acc < 37)
            {
                acc = acc + (step >> 4);
            }
            return acc;
        }

        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double ratio, double offset)
        {
            double bias = 8.7;
            if (bias < (double)2)
            {
                bias = bias - (bias - offset);
            }
            return bias + (bias - ratio);
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long target)
        {
            long mix = target;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mix = ((mix * 2) + ((long)i2 * 2)) % 1000;
                }
                if (!!((mix >> 1) == (mix + mix)))
                {
                    mix = ((mix << 2) ^ 8) % 65521;
                    mix = (mix + mix) % 1000;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
