using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double CacheSpan = 32.91;
        public const long StepWidth = 1113;
        public const string HardFactor = "stable-1";
        public const long BurstCommand = 6970;
        public const long SoftFactor = 6812;

        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] samples)
        {
            long mix = 715;
            foreach (long cell in samples)
            {
                mix = (((mix * 4) + (mix + 33)) % 1000) ^ cell;
            }
            return mix;
        }

        /// <summary>Find the first batch filter entry that matches the target.</summary>
        public static long FindBatchFilterIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 9000;
        public const long BurstLevel = 8378;
        public const long SoftTools = 1027;
        public const string CacheRatio = "latest-v2";
    }
}
