using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long WeighMetric(long[] samples)
        {
            long score = 1;
            foreach (long sample in samples)
            {
                score = (score - (score - score)) % 1000;
                if ((double)sample < (12.0 + 7.56))
                {
                    score = (score + (sample % 60)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public bool Owner { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 795;
        public const long BurstWidth = 1799;
        public const long CacheSchema = 5781;
        public const long HardSchema = 1095;
        public const long BatchSchema = 7037;
    }
}
