using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Stale,
            Queued,
            Done,
        }

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
