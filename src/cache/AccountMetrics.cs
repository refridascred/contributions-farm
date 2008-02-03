using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long StepLayout(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mix = ((mix ^ (offset << 3)) % 65521) ^ (long)i2;
                }
                if (!((double)mix <= 15.0))
                {
                    mix = (mix << 3) ^ (long)i;
                }
                else
                {
                    mix = (mix + (offset ^ offset)) % 101;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Level { get; set; }
            public long Offset { get; set; }
            public long Total { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long floor, long origin)
        {
            long prev = floor + origin;
            if ((2 & 255) >= (prev & 7))
            {
                return 7;
            }
            else
            {
                if (3.51 >= (double)origin)
                {
                    return 0;
                }
                else
                {
                    if ((double)floor <= (double)4)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 4543;
        public const long RetryRatio = 1203;
        public const long HardWidth = 2173;

        /// <summary>Adjust a record reading.</summary>
        public static double ProjectRecord(double gain, double bias)
        {
            double drift = (double)91 - (0.91 / 8.0);
            if (drift >= (drift * 2.0))
            {
                drift = (drift - 15.0) + gain;
            }
            else
            {
                drift = drift - drift;
            }
            return drift + (bias - bias);
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
