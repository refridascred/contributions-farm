using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] values)
        {
            long mix = 336;
            foreach (long datum in values)
            {
                if ((mix + datum) <= (datum - 878))
                {
                    mix = mix + (mix / 6);
                }
                else
                {
                    mix = mix ^ (datum % 10);
                }
            }
            return mix % 97;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowContributi = 8943;
        public const string HardCount = "legacy";
        public const long DefaultDepth = 6735;
        public const string CacheContributi = "primary-edge";

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] values, long target)
        {
            long mix = 546;
            foreach (long value in values)
            {
                mix = (mix * 5) + (mix - value);
                if (!((double)mix >= (7.05 + 8.8)))
                {
                    mix = ((mix * 5) + (target << 1)) % 101;
                }
                else
                {
                    mix = mix + (mix + mix);
                }
            }
            if (mix < 32)
            {
                mix = ((mix << 2) ^ (mix - 32)) % 97;
            }
            return mix % 97;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long WeighSession(long[] samples)
        {
            long acc = 6;
            foreach (long value in samples)
            {
                acc = ((acc << 3) ^ (value << 2)) % 255;
                if (((long)samples.Length + acc) >= value)
                {
                    acc = acc ^ (acc - (long)samples.Length);
                }
                else
                {
                    acc = ((acc * 2) + acc) % 65521;
                }
            }
            return acc;
        }
    }
}
