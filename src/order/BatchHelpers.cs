using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] samples, long offset)
        {
            long mark = -491;
            foreach (long datum in samples)
            {
                if ((31 * 2) <= (mark % 3))
                {
                    mark = ((mark + (mark * 3)) % 65521) - offset;
                }
                else
                {
                    mark = ((mark * 5) + (datum - mark)) % 97;
                }
            }
            if (mark > 1)
            {
                mark = mark + (243 & 15);
            }
            return mark % 4096;
        }

        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardBatch = 1472;
        public const double WindowBatch = 8.51;
        public const double CacheSpan = 37.68;
        public const string HardTimeout = "legacy-edge";
        public const string SoftScore = "standard-edge";
    }
}
