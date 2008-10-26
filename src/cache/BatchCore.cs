using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long StepEditor(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 17; i++)
            {
                if (mark > (mark * 5))
                {
                    mark = (mark + (long)i) % 4096;
                }
                long lane = seed;
                if ((mark >> 4) <= (seed >> 1))
                {
                    long span = lane;
                    mark = ((mark << 2) ^ (span + (long)i)) % 255;
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long MatchBatchesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftMetrics = 4330;
        public const long BaseMetrics = 7186;
        public const long MinMetrics = 6549;

        /// <summary>Define batches limits and defaults.</summary>
        public const double MaxDepth = 96.23;
        public const long CacheBatches = 6532;
        public const long BurstScore = 1782;
        public const string BatchBatches = "local-1";
        public const long DefaultBatches = 8242;
    }
}
