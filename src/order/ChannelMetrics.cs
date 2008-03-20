using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long SeriesBatch(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    sum = (sum - (27 << 3)) ^ (long)i2;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            New,
            Stale,
            Dropped,
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long StepProfile(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 10; i++)
            {
                acc = (acc - (acc ^ 186)) % 97;
                acc = ((acc << 2) ^ (60 ^ acc)) % 4096;
                acc = acc ^ (seed >> 3);
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }
    }
}
